using Project20.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project20.DataAccess
{
    internal class EmployeeDal 
    {
        static String link = "Data Source=Zeynep;Initial Catalog=DbWinform;";
        SqlConnection connection = new SqlConnection(link);

        List<Employee> employees;
        

        public EmployeeDal()
        {
            // Bağlantıyı aç
            connection.Open();

            // Veritabanından veri almak için bir SqlCommand oluştur
            string sqlQuery = "SELECT Id, AdSoyad, Telefon, Maas, Adres FROM Personel";
            SqlCommand command = new SqlCommand(sqlQuery, connection);

            // SqlDataReader kullanarak veriyi oku
            SqlDataReader reader = command.ExecuteReader();

            // Verileri oku ve objelere eşleştir
            employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee
                {
                    EmployeeId = reader.GetInt32(reader.GetOrdinal("Id")),
                    EmployeeNameSurname = reader.GetString(reader.GetOrdinal("AdSoyad")),
                    EmployeePhoneNumber = reader.GetString(reader.GetOrdinal("Telefon")),
                    EmployeeSalary = reader.GetInt32(reader.GetOrdinal("Maas")),
                    EmployeeAdress = reader.GetString(reader.GetOrdinal("Adres"))
                };
                employees.Add(employee);
            }

            // SqlDataReader, SqlCommand ve SqlConnection nesnelerini kapat
            reader.Close();
            command.Dispose();
            connection.Close();

            // Burada employees listesi içerisinde veriler objelerde eşlenmiş olacak
        }
        public List<Employee> GetAll()
        {
            return employees;
        }


        public void Add(Employee employee)
        {
            String insertSqlQuery = "Insert into Personel (AdSoyad, Telefon, Maas, Adres) values (@Value1, @Value2, @Value3, @Value4)";
            SqlCommand command = new SqlCommand(insertSqlQuery, connection);

            command.Parameters.AddWithValue("@Value1", $"{employee.EmployeeNameSurname}");
            command.Parameters.AddWithValue("@Value2", $"{employee.EmployeePhoneNumber}");
            command.Parameters.AddWithValue("@Value3", $"{employee.EmployeeSalary}");
            command.Parameters.AddWithValue("@Value4", $"{employee.EmployeeAdress}");

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Delete(string selectedId)
        {
            String deleteSqlQuery = "Delete from Personel Where Id = @DeleteId";
            SqlCommand command = new SqlCommand(deleteSqlQuery, connection);

            command.Parameters.AddWithValue("@DeleteId", $"{selectedId}");

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

      

        public Employee GetById(int employeeId)
        {          
            String updateSqlQuery = "SELECT Id, AdSoyad, Telefon, Maas, Adres FROM Personel WHERE Id = @employeeId";
            SqlCommand command = new SqlCommand(updateSqlQuery, connection);

            command.Parameters.AddWithValue("@UpdateId", $"{employeeId}");

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            return employees.SingleOrDefault(p=>p.EmployeeId == employeeId);
        }

        public void Update(string txtId, string txtName, string txtTelefon, string txtMaas, string txtAdres)
        {
            String updateSqlQuery = "UPDATE Personel SET AdSoyad = @AdSoyad, Telefon = @Telefon, Adres = @Adres, Maas = @Maas WHERE Id = @UpdateId";
            SqlCommand command = new SqlCommand(updateSqlQuery, connection);

            command.Parameters.AddWithValue("@AdSoyad", $"{txtName}");
            command.Parameters.AddWithValue("@Telefon", $"{txtTelefon}");
            command.Parameters.AddWithValue("@Adres", $"{txtAdres}");
            command.Parameters.AddWithValue("@Maas", $"{int.Parse(txtMaas)}");
            command.Parameters.AddWithValue("@UpdateId", $"{int.Parse(txtId)}");

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
