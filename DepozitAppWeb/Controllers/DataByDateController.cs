using DepozitApp.BLL.Interfaces;
using DepozitApp.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DepozitAppWeb.Controllers
{
    public class DataByDateController : Controller
    {

        private readonly IGetDataByDateServise getDataByDateServise;
        public DataByDateController(IGetDataByDateServise getDataByDateServise) => this.getDataByDateServise = getDataByDateServise;



        [HttpGet(template: "/GetDataByDate")] //GetDataByDate?dateCreate1=23.10.2023&dateCreate2=24.10.2023
        public IActionResult GetDataByDate(string dateCreate1, string dateCreate2)
        {
            var res = getDataByDateServise.GetDataByDate(dateCreate1, dateCreate2);

            return View(res); 
            //return Ok(res);
        }
    }
}
