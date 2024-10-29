namespace KeuanganPribadi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSaldo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTanggal = new Label();
            lblKategori = new Label();
            lblDeskripsi = new Label();
            lblJumlah = new Label();
            dateTimePicker1 = new DateTimePicker();
            cmbKategori = new ComboBox();
            txtDeskripsi = new TextBox();
            txtJumlah = new TextBox();
            btnTambah = new Button();
            btnHapus = new Button();
            dataGridView1 = new DataGridView();
            lblSaldo = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(12, 15);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(77, 25);
            lblTanggal.TabIndex = 0;
            lblTanggal.Text = "Tanggal:";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(12, 56);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(82, 25);
            lblKategori.TabIndex = 2;
            lblKategori.Text = "Kategori:";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(12, 97);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(88, 25);
            lblDeskripsi.TabIndex = 4;
            lblDeskripsi.Text = "Deskripsi:";
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(12, 140);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(71, 25);
            lblJumlah.TabIndex = 6;
            lblJumlah.Text = "Jumlah:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(100, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(319, 31);
            dateTimePicker1.TabIndex = 1;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Location = new Point(100, 53);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(200, 33);
            cmbKategori.TabIndex = 3;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(100, 94);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(319, 31);
            txtDeskripsi.TabIndex = 5;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(100, 137);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(200, 31);
            txtJumlah.TabIndex = 7;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(319, 137);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(83, 36);
            btnTambah.TabIndex = 8;
            btnTambah.Text = "submit";
            btnTambah.Click += btnTambah_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(465, 188);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(189, 36);
            btnHapus.TabIndex = 10;
            btnHapus.Text = "Hapus Transaksi";
            btnHapus.Click += btnHapus_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(12, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(646, 491);
            dataGridView1.TabIndex = 11;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSaldo.Location = new Point(12, 758);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(206, 32);
            lblSaldo.TabIndex = 12;
            lblSaldo.Text = "Total Saldo: Rp 0";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(465, 754);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(189, 36);
            btnExit.TabIndex = 13;
            btnExit.Text = "keluar";
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            BackColor = Color.LightCyan;
            ClientSize = new Size(670, 831);
            Controls.Add(btnExit);
            Controls.Add(lblTanggal);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblKategori);
            Controls.Add(cmbKategori);
            Controls.Add(lblDeskripsi);
            Controls.Add(txtDeskripsi);
            Controls.Add(lblJumlah);
            Controls.Add(txtJumlah);
            Controls.Add(btnTambah);
            Controls.Add(btnHapus);
            Controls.Add(dataGridView1);
            Controls.Add(lblSaldo);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Aplikasi Keuangan Pribadi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnExit;
    }
}
