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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4ЕИТ_А3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=DESKTOP-JAQOFEV\SQLEXPRESS;Initial Catalog=EIT_A03_EvidencijaRadnika;Integrated Security=True");
        SqlCommand kom = new SqlCommand();
        SqlDataReader dr;
        int id = 0;

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void PuniGridChart()
        {
            chart1.Titles.Clear();
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniGridChart", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Period", SqlDbType.VarChar).Value = numericUpDown1.Text.ToString();

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            chart1.DataSource = dt;
            dataGridView1.DataSource = dt;

            chart1.Series["Series1"].XValueMember = "Godina";
            chart1.Series["Series1"].YValueMembers = "BrojProjekata";
            chart1.Series["Series1"].YValueMembers = "BrRadnika";

            Kon.Close();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PuniGridChart();
        }
    }
}
