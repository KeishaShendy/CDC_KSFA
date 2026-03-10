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
