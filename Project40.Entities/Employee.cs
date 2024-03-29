using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project40.Entities
{
    public class Employee : IEntity
    {
        public int EmployeeId { get; set; }
        
        public string EmployeeNameSurname { get; set; }

        public string EmployeePhoneNumber { get; set; }

        public int EmployeeSalary { get; set; }

        public string EmployeeAdress { get; set; }


        public Employee(int EmployeeId, string EmployeeNameSurname, string EmployeePhoneNumber, int EmployeeSalary, string EmployeeAdress)
        {
            EmployeeId = EmployeeId;
            EmployeeNameSurname = EmployeeNameSurname;
            EmployeePhoneNumber = EmployeePhoneNumber;
            EmployeeSalary = EmployeeSalary;
            EmployeeAdress = EmployeeAdress;

        }

        public Employee()
        {
            
        }

    }
}
