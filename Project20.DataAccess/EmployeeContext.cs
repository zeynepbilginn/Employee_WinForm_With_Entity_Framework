using Project20.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project20.DataAccess
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("name=MyConnectionString")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
