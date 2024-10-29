using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace KeuanganPribadi
{
    public partial class Form1 : Form
    {
        private decimal totalSaldo = 0;  // Menyimpan total saldo
        private List<Transaksi> transaksiList = new List<Transaksi>();  // List untuk menyimpan transaksi
        private string jsonFilePath = "transaksi.json";  // Path untuk file JSON

        public Form1()
        {
            InitializeComponent();
            cmbKategori.Items.Add("Pemasukan");
            cmbKategori.Items.Add("Pengeluaran");
            cmbKategori.SelectedIndex = 0;
            LoadData();  // Panggil LoadData saat aplikasi dimulai
        }

        // Kelas untuk menyimpan data transaksi
        public class Transaksi
        {
            public DateTime Tanggal { get; set; }
            public string Kategori { get; set; }
            public string Deskripsi { get; set; }
            public decimal Jumlah { get; set; }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeskripsi.Text) || string.IsNullOrWhiteSpace(txtJumlah.Text) || !decimal.TryParse(txtJumlah.Text, out decimal jumlah))
            {
                MessageBox.Show("Harap masukkan deskripsi dan jumlah yang valid.");
                return;
            }

            Transaksi transaksi = new Transaksi
            {
                Tanggal = dateTimePicker1.Value,
                Kategori = cmbKategori.SelectedItem.ToString(),
                Deskripsi = txtDeskripsi.Text,
                Jumlah = jumlah
            };

            transaksiList.Add(transaksi);
            UpdateDataGridView();
            UpdateSaldo(transaksi.Kategori, transaksi.Jumlah);
            SaveData();  // Simpan data setelah penambahan
            ClearInput();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                Transaksi transaksi = transaksiList[index];

                UpdateSaldo(transaksi.Kategori, -transaksi.Jumlah);

                transaksiList.RemoveAt(index);
                UpdateDataGridView();
                SaveData();  // Simpan data setelah penghapusan
            }
            else
            {
                MessageBox.Show("Pilih transaksi yang ingin dihapus.");
            }
        }

        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = transaksiList;
        }

        private void UpdateSaldo(string kategori, decimal jumlah)
        {
            if (kategori == "Pemasukan")
                totalSaldo += jumlah;
            else
                totalSaldo -= jumlah;

            lblSaldo.Text = $"Total Saldo: Rp {totalSaldo:N2}";
        }

        private void ClearInput()
        {
            txtDeskripsi.Clear();
            txtJumlah.Clear();
            cmbKategori.SelectedIndex = 0;
        }

        private void SaveData()
        {
            try
            {
                string json = JsonSerializer.Serialize(transaksiList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(jsonFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menyimpan data: {ex.Message}");
            }
        }

        private void LoadData()
        {
            try
            {
                if (File.Exists(jsonFilePath))
                {
                    string json = File.ReadAllText(jsonFilePath);
                    transaksiList = JsonSerializer.Deserialize<List<Transaksi>>(json) ?? new List<Transaksi>();
                    UpdateDataGridView();
                    RecalculateSaldo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data: {ex.Message}");
            }
        }

        private void RecalculateSaldo()
        {
            totalSaldo = 0;
            foreach (var transaksi in transaksiList)
            {
                if (transaksi.Kategori == "Pemasukan")
                    totalSaldo += transaksi.Jumlah;
                else
                    totalSaldo -= transaksi.Jumlah;
            }
            lblSaldo.Text = $"Total Saldo: Rp {totalSaldo:N2}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this .Close();
        }
    }
}
