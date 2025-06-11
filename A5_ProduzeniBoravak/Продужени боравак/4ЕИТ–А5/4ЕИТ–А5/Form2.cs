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

namespace _4ЕИТ_А5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=DESKTOP-JAQOFEV\SQLEXPRESS;Initial Catalog=4EIT_A5_ProduzeniBoravak;Integrated Security=True"); /* MM 2 sp*/

        SqlCommand kom = new SqlCommand();

        SqlDataReader dr;

        int id = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            PuniGridChart();
        }
        private void PuniGridChart()
        {
            Kon.Open();

            SqlCommand cmd = new SqlCommand("PuniGridChart", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            chart1.DataSource = dt;
            dataGridView1.DataSource = dt;

            chart1.Series["Series1"].XValueMember = "Dan";
            chart1.Series["Series1"].YValueMembers = "BrDece";
            chart1.Titles.Add("Aktivnosti.Dan");

            Kon.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
