using DepozitApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepozitApp.DAL.Interfaces
{
    public interface IMounthlyDepozitReportRepository: IBaseRepository<MounthlyDepozitReport>
    {
        IEnumerable<MounthlyDepozitReport> SelectDataByDate(DateTime dateCreate1, DateTime dateCreate2);
    }
}
