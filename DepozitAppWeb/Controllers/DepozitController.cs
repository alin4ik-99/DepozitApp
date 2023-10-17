using DepozitApp.BLL.Interfaces;
using DepozitApp.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DepozitAppWeb.Controllers
{
    public class DepozitController : Controller
    {
        // [HttpGet, Route("depozit")] depozit?startdepozit=100&mounthplus=10&yearprocent=10&termininmounth=3



        private readonly IDepozitCalculateService depozitcalculateservice;

        public DepozitController(IDepozitCalculateService depozitcalculateservice) => this.depozitcalculateservice = depozitcalculateservice;


        [HttpGet(template: "/depozit")]
        public MounthlyDepozitReport[] Depozit(double StartDepozit, double MounthPlus, double YearProcent, int TerminInMounth)
        {

            return depozitcalculateservice.CalculateDifficultProcent(StartDepozit, MounthPlus, YearProcent, TerminInMounth);
        }

    }
}
