
using Project20.Business;
using Project20.DataAccess;
using Project20.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBWindowsForm01
{
    public partial class Form1 : Form
    {
        EmployeeManager employeeManager = new EmployeeManager(new EmployeeDal2());

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List();
        }
        void List()
        {
            dataGridView1.DataSource = employeeManager.GetDataTable();
            TxtClear();
        }

        void TxtClear()
        {
            txtId.Clear();
            txtName.Clear();
            txtTelefon.Clear();
            txtMaas.Clear();
            txtAdres.Clear();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(Convert.ToInt32(txtId.Text), txtName.Text, txtTelefon.Text, Convert.ToInt32(txtMaas.Text), txtAdres.Text);
            employeeManager.Add(employee);
            List();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            string selectedId = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            var employee = employeeManager.GetAll().SingleOrDefault(p => p.EmployeeId == Convert.ToInt32(selectedId));
            employeeManager.Delete(employee);
            List();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(Convert.ToInt32(txtId.Text), txtName.Text, txtTelefon.Text, Convert.ToInt32(txtMaas.Text), txtAdres.Text);
            employeeManager.Update(employee);
            List();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells["Maas"].Value.ToString();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells["Maas"].Value.ToString();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            TxtClear();
        }

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

















