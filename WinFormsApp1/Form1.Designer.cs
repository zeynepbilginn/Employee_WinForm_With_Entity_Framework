namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgwEmployee = new DataGridView();
            txtEmployeeId = new TextBox();
            txtEmployeeAdress = new TextBox();
            panel1 = new Panel();
            btnUpdate = new Button();
            button4 = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            btnAdd = new Button();
            btnClearText = new Button();
            lblSalary = new Label();
            lblPhoneNumber = new Label();
            lblNameSurname = new Label();
            lblAdress = new Label();
            lblId = new Label();
            txtEmployeeSalary = new TextBox();
            txtEmployeePhoneNumber = new TextBox();
            txtEmployeeNameSurname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgwEmployee).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgwEmployee
            // 
            dtgwEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgwEmployee.Dock = DockStyle.Top;
            dtgwEmployee.Location = new Point(0, 0);
            dtgwEmployee.Name = "dtgwEmployee";
            dtgwEmployee.RowHeadersWidth = 66;
            dtgwEmployee.Size = new Size(1227, 447);
            dtgwEmployee.TabIndex = 0;
            dtgwEmployee.CellClick += dtgwEmployee_CellClick;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(138, 41);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.ReadOnly = true;
            txtEmployeeId.Size = new Size(76, 33);
            txtEmployeeId.TabIndex = 1;
            // 
            // txtEmployeeAdress
            // 
            txtEmployeeAdress.Location = new Point(138, 116);
            txtEmployeeAdress.Multiline = true;
            txtEmployeeAdress.Name = "txtEmployeeAdress";
            txtEmployeeAdress.Size = new Size(1009, 150);
            txtEmployeeAdress.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnClearText);
            panel1.Controls.Add(lblSalary);
            panel1.Controls.Add(lblPhoneNumber);
            panel1.Controls.Add(lblNameSurname);
            panel1.Controls.Add(lblAdress);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(txtEmployeeSalary);
            panel1.Controls.Add(txtEmployeePhoneNumber);
            panel1.Controls.Add(txtEmployeeNameSurname);
            panel1.Controls.Add(txtEmployeeId);
            panel1.Controls.Add(txtEmployeeAdress);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 453);
            panel1.Name = "panel1";
            panel1.Size = new Size(1227, 366);
            panel1.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(418, 296);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 37);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button4
            // 
            button4.Location = new Point(-336, 300);
            button4.Name = "button4";
            button4.Size = new Size(120, 37);
            button4.TabIndex = 3;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(279, 296);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 37);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1027, 296);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 37);
            btnExit.TabIndex = 3;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(138, 296);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 37);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClearText
            // 
            btnClearText.Location = new Point(887, 296);
            btnClearText.Name = "btnClearText";
            btnClearText.Size = new Size(120, 37);
            btnClearText.TabIndex = 3;
            btnClearText.Text = "Temizle";
            btnClearText.UseVisualStyleBackColor = true;
            btnClearText.Click += btnClearText_Click;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(930, 41);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(66, 25);
            lblSalary.TabIndex = 2;
            lblSalary.Text = "Maaş :";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(544, 44);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(168, 25);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Telefon Numarası :";
            // 
            // lblNameSurname
            // 
            lblNameSurname.AutoSize = true;
            lblNameSurname.Location = new Point(235, 41);
            lblNameSurname.Name = "lblNameSurname";
            lblNameSurname.Size = new Size(100, 25);
            lblNameSurname.TabIndex = 2;
            lblNameSurname.Text = "Ad Soyad :";
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Location = new Point(34, 119);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(69, 25);
            lblAdress.TabIndex = 2;
            lblAdress.Text = "Adres :";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(43, 41);
            lblId.Name = "lblId";
            lblId.Size = new Size(37, 25);
            lblId.TabIndex = 2;
            lblId.Text = "Id :";
            // 
            // txtEmployeeSalary
            // 
            txtEmployeeSalary.Location = new Point(1002, 41);
            txtEmployeeSalary.Name = "txtEmployeeSalary";
            txtEmployeeSalary.Size = new Size(145, 33);
            txtEmployeeSalary.TabIndex = 1;
            // 
            // txtEmployeePhoneNumber
            // 
            txtEmployeePhoneNumber.Location = new Point(718, 41);
            txtEmployeePhoneNumber.Name = "txtEmployeePhoneNumber";
            txtEmployeePhoneNumber.Size = new Size(190, 33);
            txtEmployeePhoneNumber.TabIndex = 1;
            // 
            // txtEmployeeNameSurname
            // 
            txtEmployeeNameSurname.Location = new Point(341, 41);
            txtEmployeeNameSurname.Name = "txtEmployeeNameSurname";
            txtEmployeeNameSurname.Size = new Size(174, 33);
            txtEmployeeNameSurname.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 819);
            Controls.Add(panel1);
            Controls.Add(dtgwEmployee);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgwEmployee).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgwEmployee;
        private TextBox txtEmployeeId;
        private TextBox txtEmployeeAdress;
        private Panel panel1;
        private Button btnClearText;
        private Label lblSalary;
        private Label lblPhoneNumber;
        private Label lblNameSurname;
        private Label lblAdress;
        private Label lblId;
        private Button btnUpdate;
        private Button button4;
        private Button btnDelete;
        private Button btnExit;
        private Button btnAdd;
        private TextBox txtEmployeeSalary;
        private TextBox txtEmployeePhoneNumber;
        private TextBox txtEmployeeNameSurname;
    }
}
