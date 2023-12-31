﻿using Azure.Core;
using DepozitApp.BLL.Interfaces;
using DepozitApp.DAL.Interfaces;
using DepozitApp.Domain.Entities;
using DepozitApp.Domain.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DepozitApp.BLL.Services
{
    public class GetCurrenciesReportServise : IGetCurrenciesReportServise
    {


        private readonly IBaseRepository<CurrenciesReport> _currenciesReportRepository;
        private readonly IGetRequestService _getRequestService;

        public GetCurrenciesReportServise(IBaseRepository<CurrenciesReport> _currenciesReportRepository, IGetRequestService _getRequestService)
        {
           
            this._currenciesReportRepository = _currenciesReportRepository;
            this._getRequestService = _getRequestService;   

        }



        public CurrenciesReportViewModel GetCurrenciesReport(string baseCurrency, string date)
        {
            DateTime _date = DateTime.Parse(date);
           
            var currency = baseCurrency+".json";

            string str = "https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/"+date+"/currencies/"+currency;

            _getRequestService.Run(str);
       
            var response = _getRequestService.Response;


            var json = JObject.Parse(response);
            var currency_api = json[baseCurrency];


            var _currenciesReport = new CurrenciesReport();

                _currenciesReport.BaseCurrency = baseCurrency;
                _currenciesReport.Date = _date;
                _currenciesReport.Bitcoin = (string)currency_api["btc"];
                _currenciesReport.Euro = (string)currency_api["eur"];
                _currenciesReport.Dollar = (string)currency_api["usd"];


            _currenciesReportRepository.Create(_currenciesReport);


            var _currenciesReportViewModel = new CurrenciesReportViewModel();
            { 
                _currenciesReportViewModel.BaseCurrency = _currenciesReport.BaseCurrency;
                _currenciesReportViewModel.Date = _currenciesReport.Date;
                _currenciesReportViewModel.Bitcoin = _currenciesReport.Bitcoin;
                _currenciesReportViewModel.Euro = _currenciesReport.Euro;
                _currenciesReportViewModel.Dollar = _currenciesReport.Dollar;
            }



            return _currenciesReportViewModel;
        }
    }
}
