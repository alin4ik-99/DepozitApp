using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepozitApp.Domain.Entities
{
    public class DollarCurrencyReport
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Bitcoin { get; set; }
        public string Euro { get; set; }
        public string UAH { get; set; }
    }
}
