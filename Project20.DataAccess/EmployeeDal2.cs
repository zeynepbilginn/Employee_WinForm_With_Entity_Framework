using Project20.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Project20.DataAccess
{
    public class EmployeeDal2 : IEmployeeDal
    {
        public void Add(Employee entity)
        {
            using(EmployeeContext contex =  new EmployeeContext())
            {
                contex.Employees.Add(entity);
            }
        }

        public void Delete(Employee entity)
        {
            using (EmployeeContext contex = new EmployeeContext())
            {
                contex.Employees.Remove(contex.Employees.SingleOrDefault(p => p.EmployeeId == entity.EmployeeId));
                contex.SaveChanges();
            }
        }

        public List<Employee> GetAll()
        {
            using (EmployeeContext contex = new EmployeeContext())
            { 
                return contex.Employees.ToList();
            }
        }

        public Employee GetById(int id)
        {
            using(EmployeeContext contex = new EmployeeContext())
            {
                return contex.Employees.SingleOrDefault(p => (p.EmployeeId == id));
            }
        }

        public void Update(Employee entity)
        {
            using (EmployeeContext contex = new EmployeeContext())
            {
                var EmployeeToUpdate = contex.Employees.SingleOrDefault(p => (p.EmployeeId == entity.EmployeeId));
                EmployeeToUpdate.EmployeeNameSurname = entity.EmployeeNameSurname;
                EmployeeToUpdate.EmployeePhoneNumber = entity.EmployeePhoneNumber;
                EmployeeToUpdate.EmployeeSalary = entity.EmployeeSalary;
                EmployeeToUpdate.EmployeeAdress = entity.EmployeeAdress;

                contex.SaveChanges();
            }
        }
    }
}
