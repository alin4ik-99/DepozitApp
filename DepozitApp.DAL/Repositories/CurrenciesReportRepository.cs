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
    public class CurrenciesReportRepository : IBaseRepository<CurrenciesReport>
    {
        private readonly DataContext dbContex;
        public CurrenciesReportRepository(DataContext dbContex) => this.dbContex = dbContex;

        public void Create(CurrenciesReport entity)
        {
            dbContex.CurrenciesReports.Add(entity);
            dbContex.SaveChanges();
        }

        public void Delete(CurrenciesReport entity)
        {
            if (entity != null)
            {
                dbContex.CurrenciesReports.Remove(entity);
                dbContex.SaveChanges();
            }
        }

        public CurrenciesReport Get(int id)
        {
            return dbContex.CurrenciesReports.Find(id);
        }

        public IEnumerable<CurrenciesReport> GetAll()
        {
            return dbContex.CurrenciesReports.ToList();
        }
    }
}
