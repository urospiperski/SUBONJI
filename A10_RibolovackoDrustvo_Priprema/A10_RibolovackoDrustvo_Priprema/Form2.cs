using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace A10_RibolovackoDrustvo_Priprema
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=URKE\SQLEXPRESS;Initial Catalog=4EIT_A10_RibolovackoDrustvo;Integrated Security=True"); /* MM 2 sp*/

        SqlCommand kom = new SqlCommand();

        SqlDataReader dr;

        int id = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            PuniComboPecaros();
        }

        private void PuniComboPecaros()
        {

            
            Kon.Open();

            SqlCommand cmd = new SqlCommand("PuniComboPecaros", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cmbPecaros.DataSource = dt;
            cmbPecaros.DisplayMember = "Pecaros";

            Kon.Close();
        }

        private void PuniGridChart()
        {
            string Par_Pecaros = cmbPecaros.Text;
            string[] PPecaros = Par_Pecaros.Split('-');

            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniGridiChart", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PecarosID", SqlDbType.VarChar).Value = PPecaros[0].ToString().Trim();
            cmd.Parameters.AddWithValue("@DatumOD", SqlDbType.Date).Value = dateTimePicker1.Value;
            cmd.Parameters.AddWithValue("@DatumDO", SqlDbType.Date).Value = dateTimePicker2.Value;

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            chart1.DataSource = dt;
            dataGridView1.DataSource = dt;

            chart1.Series["Series1"].XValueMember = "Naziv";
            chart1.Series["Series1"].YValueMembers = "Broj";
            chart1.Titles.Add("RIBOLOV");

            Kon.Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            PuniGridChart();
        }
    }
}
