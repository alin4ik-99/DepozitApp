using DepozitApp.BLL.Interfaces;
using DepozitApp.DAL.Entities;
using DepozitApp.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepozitApp.BLL.Services
{
    public class GetDataByDateServise : IGetDataByDateServise
    {
        private readonly IMounthlyDepozitReportRepository _mounthlyDepozitReportRepository;

        public GetDataByDateServise(IMounthlyDepozitReportRepository _mounthlyDepozitReportRepository) => this._mounthlyDepozitReportRepository = _mounthlyDepozitReportRepository;

        public IEnumerable<MounthlyDepozitReport> GetDataByDate(string dateCreate1, string dateCreate2)
        {  
            DateTime dateFirst = DateTime.Parse(dateCreate1);
            DateTime dateSecond = DateTime.Parse(dateCreate2);

           IEnumerable<MounthlyDepozitReport> queryDataByDate = _mounthlyDepozitReportRepository.SelectDataByDate(dateFirst, dateSecond);

           return queryDataByDate;   
        }
    }
}
