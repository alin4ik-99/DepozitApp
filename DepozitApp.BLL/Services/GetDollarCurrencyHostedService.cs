using DepozitApp.BLL.Interfaces;
using DepozitApp.DAL.Interfaces;
using DepozitApp.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace DepozitApp.BLL.Services
{
    public class GetDollarCurrencyHostedService : BackgroundService
    {
        private Timer? _timer;

        private readonly IServiceProvider dollarCurrencyReportRepositoryService;
        private readonly IServiceProvider getRequestService;

        public GetDollarCurrencyHostedService( IServiceProvider _dollarCurrencyReportRepositoryService, IServiceProvider _getRequestService)
        {

            dollarCurrencyReportRepositoryService = _dollarCurrencyReportRepositoryService;
            getRequestService = _getRequestService;
        }



        public void GetDollarCurrency(object? state)
        {
            using (var scope = getRequestService.CreateScope())
            {
                var scopeGetRequestService =
                   scope.ServiceProvider
                .GetRequiredService<IGetRequestService>();


                string str = "https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/usd.json";
                scopeGetRequestService.Run(str);
                var response = scopeGetRequestService.Response;


                var json = JObject.Parse(response);

                var data = json["date"];

                DateTime _date = DateTime.Parse((string)data);

                var currency_api = json["usd"];

                  var _dollarCurrencyReport = new DollarCurrencyReport();

                       _dollarCurrencyReport.Date = _date;
                       _dollarCurrencyReport.Bitcoin = (string)currency_api["btc"];
                       _dollarCurrencyReport.Euro = (string)currency_api["eur"];
                       _dollarCurrencyReport.UAH = (string)currency_api["uah"];


                using (var scope2 = dollarCurrencyReportRepositoryService.CreateScope())
                {
                
                        var scopeddollarCurrencyReportRepositoryService =
                           scope2.ServiceProvider
                        .GetRequiredService<IBaseRepository<DollarCurrencyReport>>();

                    scopeddollarCurrencyReportRepositoryService.Create(_dollarCurrencyReport);

                }  
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            TimerCallback tm = new TimerCallback(GetDollarCurrency);
            _timer = new Timer(tm, null, 0, 10000);
            return Task.CompletedTask;
        }
    }

      
}
