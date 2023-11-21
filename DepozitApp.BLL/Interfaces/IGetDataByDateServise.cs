using DepozitApp.Domain.Entities;
using DepozitApp.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepozitApp.BLL.Interfaces
{
    public interface IGetDataByDateServise
    {
        public IEnumerable<MounthlyDepozitReportViewModel> GetDataByDate(string dateCreate1, string dateCreate2);
    }
}
