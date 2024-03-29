using System;

namespace DBWindowsForm01
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonCıkıs = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelMaas = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 66;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1262, 571);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(414, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(164, 27);
            this.txtName.TabIndex = 1;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(164, 201);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(129, 38);
            this.buttonEkle.TabIndex = 2;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(675, 28);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(183, 27);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(940, 28);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(138, 27);
            this.txtMaas.TabIndex = 4;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(164, 89);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(914, 79);
            this.txtAdres.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonTemizle);
            this.panel2.Controls.Add(this.buttonCıkıs);
            this.panel2.Controls.Add(this.buttonGuncelle);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.labelTelefon);
            this.panel2.Controls.Add(this.labelMaas);
            this.panel2.Controls.Add(this.labelAdres);
            this.panel2.Controls.Add(this.labelAdSoyad);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.buttonSil);
            this.panel2.Controls.Add(this.txtTelefon);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.buttonEkle);
            this.panel2.Controls.Add(this.txtAdres);
            this.panel2.Controls.Add(this.txtMaas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 262);
            this.panel2.TabIndex = 7;
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(805, 198);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(129, 40);
            this.buttonTemizle.TabIndex = 11;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonCıkıs
            // 
            this.buttonCıkıs.Location = new System.Drawing.Point(949, 198);
            this.buttonCıkıs.Name = "buttonCıkıs";
            this.buttonCıkıs.Size = new System.Drawing.Size(129, 40);
            this.buttonCıkıs.TabIndex = 11;
            this.buttonCıkıs.Text = "Çıkış";
            this.buttonCıkıs.UseVisualStyleBackColor = true;
            this.buttonCıkıs.Click += new System.EventHandler(this.buttonCıkıs_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(490, 198);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(129, 40);
            this.buttonGuncelle.TabIndex = 11;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(164, 28);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 27);
            this.txtId.TabIndex = 10;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(584, 31);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(79, 20);
            this.labelTelefon.TabIndex = 9;
            this.labelTelefon.Text = "Telefon : ";
            // 
            // labelMaas
            // 
            this.labelMaas.AutoSize = true;
            this.labelMaas.Location = new System.Drawing.Point(874, 31);
            this.labelMaas.Name = "labelMaas";
            this.labelMaas.Size = new System.Drawing.Size(60, 20);
            this.labelMaas.TabIndex = 8;
            this.labelMaas.Text = "Maaş :";
            this.labelMaas.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(80, 92);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(63, 20);
            this.labelAdres.TabIndex = 8;
            this.labelAdres.Text = "Adres :";
            this.labelAdres.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(300, 31);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(90, 20);
            this.labelAdSoyad.TabIndex = 8;
            this.labelAdSoyad.Text = "Ad Soyad :";
            this.labelAdSoyad.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(111, 31);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(32, 20);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "Id :";
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(326, 201);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(129, 37);
            this.buttonSil.TabIndex = 6;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 744);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelMaas;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonCıkıs;
        private System.Windows.Forms.Button buttonTemizle;
    }
}

