using Project40.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project40.DataAccess
{
    public class EmployeeDal : IEmployeeDal
    {
        public void Add(Employee entity)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                context.Employees.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(Employee entity)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                context.Employees.Remove(context.Employees.SingleOrDefault(e => e.EmployeeId == entity.EmployeeId));
                context.SaveChanges();
            }
        }

        public List<Employee> GetAll()
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                return context.Employees.ToList();
            }
        }

        public Employee GetById(int id)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                return context.Employees.SingleOrDefault(e => e.EmployeeId == id);
            }
        }

        public void Update(Employee entity)
        {
            using (EmployeeContext context = new EmployeeContext())
            {
                Employee EmployeeToUpdate = context.Employees.SingleOrDefault(e => (e.EmployeeId == entity.EmployeeId));
                EmployeeToUpdate.EmployeeNameSurname = entity.EmployeeNameSurname;
                EmployeeToUpdate.EmployeePhoneNumber = entity.EmployeePhoneNumber;
                EmployeeToUpdate.EmployeeSalary = entity.EmployeeSalary;
                EmployeeToUpdate.EmployeeAdress = entity.EmployeeAdress;

                context.SaveChanges();
            }
        }
    }
}
