using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A17_EvVozila_Blok_13052025
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=DESKTOP-HHPNNPS\SQLEXPRESS;Initial Catalog=4EIT_A17_EvidencijaVozila;Integrated Security=True"); /* MM 2 sp*/

        SqlCommand kom = new SqlCommand();

        SqlDataReader dr;

        int id = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            PuniComboModel();
        }

        private void PuniComboModel()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniComboModel", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbModel.DataSource = dt;
            cmbModel.DisplayMember = "Naziv";
            Kon.Close();
        }

        private void PuniGridChart()
        {
            chart1.Titles.Clear();
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniGridChart", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Model", SqlDbType.VarChar).Value = cmbModel.Text.ToString();

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            chart1.DataSource = dt;
            dataGridView1.DataSource = dt;

            chart1.Series["Series1"].XValueMember = "GodinaProizvodnje";
            chart1.Series["Series1"].YValueMembers = "ProsecnaCena";
            chart1.Titles.Add("VOZILA");

            Kon.Close();

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            PuniGridChart();
        }
    }
}
