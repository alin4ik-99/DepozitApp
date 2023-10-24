using DepozitApp.DAL.EF;
using DepozitApp.DAL.Entities;
using DepozitApp.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DepozitApp.DAL.Repositories
{
    public class MounthlyDepozitReportRepository : IMounthlyDepozitReportRepository
    {
        private readonly DataContext dbContex;
        public MounthlyDepozitReportRepository(DataContext dbContex) => this.dbContex = dbContex;



        public void Create(MounthlyDepozitReport entity)
        {
            dbContex.MounthlyDepozitReports.Add(entity);
            dbContex.SaveChanges();
        }


        public void Delete(MounthlyDepozitReport entity)
        {
            if (entity != null) 
            {
                dbContex.MounthlyDepozitReports.Remove(entity);
                dbContex.SaveChanges();
            }
        }


        public MounthlyDepozitReport Get(int id)
        {
            return dbContex.MounthlyDepozitReports.Find(id);  

        }


        public IEnumerable<MounthlyDepozitReport> SelectDataByDate(DateTime dateCreate1, DateTime dateCreate2)

        {
            IEnumerable <MounthlyDepozitReport> queryDataByDate = dbContex.MounthlyDepozitReports.Where(c => c.DateCreate > dateCreate1 && c.DateCreate < dateCreate2).ToList();

            return queryDataByDate;
        }

    }
}
