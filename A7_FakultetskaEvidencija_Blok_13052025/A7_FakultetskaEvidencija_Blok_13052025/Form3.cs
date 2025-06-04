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

namespace A7_FakultetskaEvidencija_Blok_13052025
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=DESKTOP-HHPNNPS\SQLEXPRESS;Initial Catalog=4EIT_A7_FakultetskaEvidencija;Integrated Security=True"); /* MM 2 sp*/

        SqlCommand kom = new SqlCommand();

        SqlDataReader dr;

        int id = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            PuniCheckLB();
        }

        private void PuniGridChart()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniGridChart", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Predmet1", SqlDbType.VarChar).Value = checkedListBox1.CheckedItems[0].ToString();
            cmd.Parameters.AddWithValue("@Predmet2", SqlDbType.VarChar).Value = checkedListBox1.CheckedItems[1].ToString();
            cmd.Parameters.AddWithValue("@Predmet3", SqlDbType.VarChar).Value = checkedListBox1.CheckedItems[2].ToString();
            cmd.Parameters.AddWithValue("@Predmet4", SqlDbType.VarChar).Value = checkedListBox1.CheckedItems[3].ToString();


            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            chart1.DataSource = dt;
            dataGridView1.DataSource = dt;

            chart1.Series["Series1"].XValueMember = "Predmet";
            chart1.Series["Series1"].YValueMembers = "2020";
            chart1.Series["Series2"].YValueMembers = "2021";
            chart1.Series["Series3"].YValueMembers = "2022";

            chart1.Titles.Add("PREDMETI");

            Kon.Close();
        }
        private void PuniCheckLB()
        {
            int i;

            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniCheckListBox", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            for (i = 0; i < dt.Rows.Count; i++)
            {
                checkedListBox1.Items.Add(dt.Rows[i]["Predmet"].ToString());
            }

            Kon.Close();

        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            PuniGridChart();
        }
    }
}
