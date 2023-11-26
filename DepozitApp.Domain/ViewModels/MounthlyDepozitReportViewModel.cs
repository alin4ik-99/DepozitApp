using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepozitApp.Domain.ViewModels
{
    public class MounthlyDepozitReportViewModel
    {
      
        public int NumberMounth { get; set; }
        public double MounthDepozit { get; set; }
        public double MounthlyIncome { get; set; }
        public double MounthlyPlus { get; set; }
        public DateTime DateCreate { get; set; }

    }
}
