using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepozitApp.Domain.ViewModels
{
    public class CurrenciesReportViewModel
    {
        public string BaseCurrency { get; set; }
        public DateTime Date { get; set; }
        public string Bitcoin { get; set; }
        public string Euro { get; set; }
        public string Dollar { get; set; }
    }
}
