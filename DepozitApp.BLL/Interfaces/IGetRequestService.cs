using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepozitApp.BLL.Interfaces
{
    public interface IGetRequestService
    {
        public string Response { get; set; }
        public void Run(string url);
    }
}
