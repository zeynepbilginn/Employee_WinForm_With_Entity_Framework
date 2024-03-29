using Project40.Business;
using Project40.DataAccess;
using Project40.Entities;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        EmployeeManager employeeManager;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employeeManager = new EmployeeManager(new EmployeeDal());
            List();
        }

        void List()
        {

            dtgwEmployee.DataSource = employeeManager.GetDataTable();
            dtgwEmployee.Refresh();

        }

        void TxtClear()
        {
            txtEmployeeId.Clear();
            txtEmployeeNameSurname.Clear();
            txtEmployeePhoneNumber.Clear();
            txtEmployeeSalary.Clear();
            txtEmployeeAdress.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                EmployeeNameSurname = txtEmployeeNameSurname.Text,
                EmployeePhoneNumber = txtEmployeePhoneNumber.Text,
                EmployeeSalary = Convert.ToInt32(txtEmployeeSalary.Text),
                EmployeeAdress = txtEmployeeAdress.Text
            };
            employeeManager.Add(employee);
            List();
            TxtClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string selectedId = dtgwEmployee.CurrentRow.Cells["Id"].Value.ToString();
            var employee = employeeManager.GetAll().SingleOrDefault(p => p.EmployeeId == Convert.ToInt32(selectedId));
            employeeManager.Delete(employee);
            List();
            TxtClear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {   
                EmployeeId = Convert.ToInt32(txtEmployeeId.Text),
                EmployeeNameSurname = txtEmployeeNameSurname.Text,
                EmployeePhoneNumber = txtEmployeePhoneNumber.Text,
                EmployeeSalary = Convert.ToInt32(txtEmployeeSalary.Text),
                EmployeeAdress = txtEmployeeAdress.Text
            };

            employeeManager.Update(employee);
            List();
        }

        private void dtgwEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string idCellValue = dtgwEmployee.CurrentRow.Cells["Id"].Value.ToString();
            if (!string.IsNullOrEmpty(idCellValue))
            {
                int employeeId = Convert.ToInt32(idCellValue);
                Employee employee = employeeManager.GetById(employeeId);

                if (employee != null)
                {
                    txtEmployeeId.Text = employee.EmployeeId.ToString();
                    txtEmployeeNameSurname.Text = employee.EmployeeNameSurname;
                    txtEmployeePhoneNumber.Text = employee.EmployeePhoneNumber;
                    txtEmployeeAdress.Text = employee.EmployeeAdress;
                    txtEmployeeSalary.Text = employee.EmployeeSalary.ToString();
                }
            }
        }
        private void btnClearText_Click(object sender, EventArgs e)
        {
            TxtClear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
