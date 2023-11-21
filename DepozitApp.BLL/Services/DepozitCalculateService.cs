using DepozitApp.BLL.Interfaces;
using DepozitApp.DAL.Interfaces;
using DepozitApp.Domain.Entities;

namespace DepozitApp.BLL.Services
{
    public class DepozitCalculateService : IDepozitCalculateService
    {
        

        private readonly IBaseRepository<MounthlyDepozitReport> db;
        public DepozitCalculateService(IBaseRepository<MounthlyDepozitReport> db) => this.db = db;


        private double CalculateMounthProcent(double yearprocent)
        {
            return (double)(Math.Pow((1.0 + (double)yearprocent / 100.0), 1 / 12D) - 1) * 100;
        }


        public MounthlyDepozitReport[] CalculateDifficultProcent(double startDepozit, double mounthPlus, double yearProcent, int terminInMounth)
        {


            MounthlyDepozitReport[] depozitReports = new MounthlyDepozitReport[terminInMounth];

            for (int i = 0; i < terminInMounth; i++)

            {
                var mounthlyDepozitReport = new MounthlyDepozitReport();

                double MounthlyIncome = startDepozit * (CalculateMounthProcent(yearProcent) / 100);
                startDepozit += MounthlyIncome;
                startDepozit += mounthPlus;

                mounthlyDepozitReport.NumberMounth = i + 1;
                mounthlyDepozitReport.MounthDepozit = startDepozit;
                mounthlyDepozitReport.MounthlyIncome = MounthlyIncome;
                mounthlyDepozitReport.MounthlyPlus = mounthPlus;
                mounthlyDepozitReport.DateCreate = DateTime.Now;

                depozitReports[i] = mounthlyDepozitReport;


                db.Create(mounthlyDepozitReport);

            }

            return depozitReports;
        }
    }
}
