using DepozitApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepozitApp.BLL.Interfaces
{
    public interface IDepozitCalculateService
    {
        public MounthlyDepozitReport[] CalculateDifficultProcent(double startDepozit, double mounthPlus, double yearProcent, int terminInMounth);
    }
}
