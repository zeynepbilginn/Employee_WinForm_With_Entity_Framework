using Microsoft.EntityFrameworkCore;
using Project40.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project40.DataAccess
{
    public class EmployeeContext : DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ZEYNEP\\SQLEXPRESS;Database=DbEmployees;User Id=sa;Password=123456;Encrypt=True;TrustServerCertificate=True;");


        }

        public DbSet<Employee> Employees { get; set; }
    }

    
}

