using DepozitApp.Domain.Entities;
using DepozitApp.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepozitApp.BLL.Interfaces
{
    public interface IGetCurrenciesReportServise
    {
        public CurrenciesReportViewModel GetCurrenciesReport(string baseCurrency, string date);
    }
}
