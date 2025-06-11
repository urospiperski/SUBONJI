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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace _4ЕИТ_А5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=DESKTOP-JAQOFEV\SQLEXPRESS;Initial Catalog=4EIT_A5_ProduzeniBoravak;Integrated Security=True"); /* MM 2 sp*/

        SqlCommand kom = new SqlCommand();

        SqlDataReader dr;

        int id = 0;

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        private void puniLV()
        {
            listView1.Items.Clear();
            Kon.Open();

            SqlCommand cmd = new SqlCommand("PuniListView", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem red = new ListViewItem(dr[0].ToString());
                for (int i = 1; i < 5; i++)
                    red.SubItems.Add(dr[i].ToString());
                listView1.Items.Add(red);
            }
            Kon.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            puniLV();
            textBox1.Enabled = false;
            listView1.Enabled = true;
            listView1.FullRowSelect = true;
        }
        private void SaLVNakontrole()
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                id = Convert.ToInt32(item.SubItems[0].Text);

                textBox1.Text = id.ToString();
                textBox2.Text = item.SubItems[1].Text;
                comboBox1.Text = item.SubItems[2].Text;
                textBox3.Text = item.SubItems[3].Text;
                textBox4.Text = item.SubItems[4].Text;
    

            }
        }
        private void UnesiAktivnost()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("UnesiAktivnost", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NazivAktivnosti", SqlDbType.VarChar).Value = textBox2.Text.ToString();
            cmd.Parameters.AddWithValue("@Dan", SqlDbType.VarChar).Value = comboBox1.Text.ToString();
            cmd.Parameters.AddWithValue("@Pocetak", SqlDbType.Time).Value = textBox3.Text.ToString();
            cmd.Parameters.AddWithValue("@Zavrsetak", SqlDbType.Time).Value = textBox4.Text.ToString();
           

            cmd.ExecuteNonQuery();

            Kon.Close();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaLVNakontrole();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnesiAktivnost();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
