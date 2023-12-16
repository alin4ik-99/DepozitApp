using DepozitApp.DAL.EF;
using DepozitApp.DAL.Interfaces;
using DepozitApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepozitApp.DAL.Repositories
{
    
    public class DollarCurrencyReportRepository : IBaseRepository<DollarCurrencyReport> 
    {
        private readonly DataContext dbContex;
        public DollarCurrencyReportRepository(DataContext dbContex) => this.dbContex = dbContex;

        public void Create(DollarCurrencyReport entity)
        {
            dbContex.DollarCurrencyReports.Add(entity);
            dbContex.SaveChanges();
        }

        public void Delete(DollarCurrencyReport entity)
        {
            if (entity != null)
            {
                dbContex.DollarCurrencyReports.Remove(entity);
                dbContex.SaveChanges();
            }
        }

        public DollarCurrencyReport Get(int id)
        {
            return dbContex.DollarCurrencyReports.Find(id);
        }

        public IEnumerable<DollarCurrencyReport> GetAll()
        {
            return dbContex.DollarCurrencyReports.ToList();
        }
    }
}
