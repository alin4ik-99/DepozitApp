using DepozitApp.BLL.Interfaces;
using DepozitApp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;


namespace DepozitAppWeb.Controllers
{
    public class DepozitController : Controller
    {
        // [HttpGet, Route("depozit")] depozit/getdepozit?startdepozit=100&mounthplus=10&yearprocent=10&termininmounth=3

        private readonly IDepozitCalculateService depozitcalculateservice;

        public DepozitController(IDepozitCalculateService depozitcalculateservice) => this.depozitcalculateservice = depozitcalculateservice;


        [HttpGet]
        public IActionResult GetDepozit(double StartDepozit, double MounthPlus, double YearProcent, int TerminInMounth)
        {
            var res = depozitcalculateservice.CalculateDifficultProcent(StartDepozit, MounthPlus, YearProcent, TerminInMounth);
            return Ok(res);
        }

    }
}
