using DepozitApp.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DepozitAppWeb.Controllers
{
    public class CurrenciesReportController : Controller //CurrenciesReport/GetCurrenciesReports?baseCurrency=usd&date=2023-11-21
    {
        private readonly IGetCurrenciesReportServise _getCurrenciesReportServise;
        public CurrenciesReportController(IGetCurrenciesReportServise _getCurrenciesReportServise) => this._getCurrenciesReportServise = _getCurrenciesReportServise;

        [HttpGet]
        public IActionResult GetCurrenciesReports(string baseCurrency, string date)
        {
            var res = _getCurrenciesReportServise.GetCurrenciesReport(baseCurrency, date);
            return Ok(res);
        }
    }
}
