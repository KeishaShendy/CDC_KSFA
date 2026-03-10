// Inisialisasi form koneksi database
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AkademikADOApp
{
    public partial class Form1 : Form
    {
        string connString = @"Data Source=LAPTOP-MBD0B33T\SHENDY;Initial Catalog=DBAkademikADO;Integrated Security=True";
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                lblStatus.Text = "Status : Database Connected";
                MessageBox.Show("Koneksi ke database berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    lblStatus.Text = "Status : Database Disconnected";
                    MessageBox.Show("Koneksi database berhasil ditutup!");
                }
                else
                {
                    MessageBox.Show("Koneksi belum terbuka.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal disconnect: " + ex.Message);
}