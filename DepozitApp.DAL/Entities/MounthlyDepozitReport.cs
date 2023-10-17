
using System.ComponentModel.DataAnnotations;

namespace DepozitApp.DAL.Entities
{
    public class MounthlyDepozitReport
    {
        [Key]
        public int MounthId { get; set; }
        public int NumberMounth { get; set; }
        public double MounthDepozit { get; set; }
        public double MounthlyIncome { get; set; }
        public double MounthlyPlus { get; set; }

    }
}
