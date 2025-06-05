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

namespace A11EvidencijaKnjiga_Priprema
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=DESKTOP-HHPNNPS\SQLEXPRESS;Initial Catalog=4EIT_A11_EvidencijaKnjiga;Integrated Security=True"); /* MM 2 sp*/

        SqlCommand kom = new SqlCommand();

        SqlDataReader dr;
        private void Form2_Load(object sender, EventArgs e)
        {
            PuniCHK();
        }

        private void PuniCHK()
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
                checkedListBox1.Items.Add(dt.Rows[i]["Autor"].ToString());
            }

            Kon.Close();
        }

        private void PuniGridChart()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniChart", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Autor1", SqlDbType.VarChar).Value = checkedListBox1.CheckedItems[0].ToString();
            cmd.Parameters.AddWithValue("@Autor2", SqlDbType.VarChar).Value = checkedListBox1.CheckedItems[1].ToString();
            cmd.Parameters.AddWithValue("@Autor3", SqlDbType.VarChar).Value = checkedListBox1.CheckedItems[2].ToString();

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            chart1.DataSource = dt;
            
            chart1.Series["Series1"].XValueMember = "Autor";
            chart1.Series["Series1"].YValueMembers = "BrKnjiga";
            chart1.Titles.Add("AUTORI");

            Kon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            PuniGridChart();
        }
    }
}
