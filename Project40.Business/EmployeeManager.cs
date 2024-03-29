using Project40.DataAccess;
using Project40.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project40.Business
{
    public class EmployeeManager :IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public DataTable GetDataTable()
        {
            List<Employee> tempEmployees = _employeeDal.GetAll();
            DataTable employeeDataTable = new DataTable();

            employeeDataTable.Columns.Add("Id", typeof(int));
            employeeDataTable.Columns.Add("AdSoyad", typeof(string));
            employeeDataTable.Columns.Add("Telefon", typeof(string));
            employeeDataTable.Columns.Add("Maas", typeof(int));
            employeeDataTable.Columns.Add("Adres", typeof(string));

            foreach (var employee in tempEmployees)
            {
                employeeDataTable.Rows.Add(employee.EmployeeId, employee.EmployeeNameSurname, employee.EmployeePhoneNumber, employee.EmployeeSalary, employee.EmployeeAdress);
            }
            return employeeDataTable;
        }

        public Employee GetById(int employeeId)
        {
            return _employeeDal.GetById(employeeId);
        }
        public void Add(Employee employee)
        {

            _employeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }

        public void Update(Employee employee)
        {

            _employeeDal.Update(employee);
        }


    }
}
