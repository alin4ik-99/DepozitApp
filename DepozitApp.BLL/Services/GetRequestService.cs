using Azure;
using DepozitApp.BLL.Interfaces;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DepozitApp.BLL.Services
{
    public class GetRequestService : IGetRequestService
    {
        public string Response { get; set; }

        public void Run(string url)
        {


            using (var client = new HttpClient())
            {
                var result = client.GetAsync(url).Result;

                Response = result.Content.ReadAsStringAsync().Result;
   
            }


        }

    }
    
}
