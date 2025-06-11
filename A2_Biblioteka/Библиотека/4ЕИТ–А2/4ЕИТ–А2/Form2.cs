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

namespace _4ЕИТ_А2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=DESKTOP-JAQOFEV\SQLEXPRESS;Initial Catalog=EIT_А02_Biblioteka;Integrated Security=True"); /* MM 2 sp*/

        SqlCommand kom = new SqlCommand();

        SqlDataReader dr;

        int id = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            comboAutor();
        }

        private void comboAutor()
        {
            Kon.Open();

            SqlCommand cmd = new SqlCommand("PuniComboAutor", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Autor";

            Kon.Close();
        }
        private void PuniGridChart()
        {
            chart1.Titles.Clear();
            string Autor = comboBox1.Text.ToString();
            string[] AutorID = Autor.Split('-');

            Kon.Open();

            SqlCommand cmd = new SqlCommand("PuniGridChart", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SifraAutora", SqlDbType.NVarChar).Value = AutorID[0].Trim().ToString();
            cmd.Parameters.AddWithValue("@Period", SqlDbType.NVarChar).Value = numericUpDown1.Value;

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            dataGridView1.DataSource = dt;

            chart1.DataSource = dt;

            chart1.Series["Series1"].XValueMember = "GodUzimanja";
            chart1.Series["Series1"].YValueMembers = "BrIznajmljivanja";
            chart1.Titles.Add("Autori");

            Kon.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PuniGridChart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
