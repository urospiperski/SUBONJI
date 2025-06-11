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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4ЕИТ_А6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=DESKTOP-JAQOFEV\SQLEXPRESS;Initial Catalog=4EIT_А6_PolovniAutomobili;Integrated Security=True");
        SqlCommand kom = new SqlCommand();
        SqlDataReader dr;
        int id = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            PuniLV();
        }
        private void PuniLV()
        {

            listView1.Items.Clear();

            Kon.Open();

            SqlCommand cmd = new SqlCommand("PuniListBoxModeli", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                ListViewItem red = new ListViewItem(dr[0].ToString());
                for (int i = 1; i < 1; i++)
                    red.SubItems.Add(dr[i].ToString());
                listView1.Items.Add(red);
            }
            Kon.Close();
        }
        private void Izmena()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("IzmeniModel", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ModelNaziv", SqlDbType.VarChar).Value = textBox2.Text.ToString();
            cmd.Parameters.AddWithValue("@ModelID", SqlDbType.VarChar).Value = textBox2.Text.ToString();

            int affectedRows = cmd.ExecuteNonQuery();

            Kon.Close();

            if (affectedRows > 0)
            {
                MessageBox.Show("Uspesno izmenjeno!");
                PuniLV();
            }

        }

        private void brojRaspolozivihVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
            f2.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedText = listView1.SelectedItems[0].Text;

                string[] parts = selectedText.Split(new string[] { " - " }, StringSplitOptions.None);

                if (parts.Length >= 3)
                {
                    textBox3.Text = parts[0].Trim();
                    textBox2.Text = parts[1].Trim();
                    comboBox1.Text = parts[2].Trim();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Simple validation
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Sva tri polja moraju biti popunjena!");
                return;
            }

            Izmena();
        }
    }

}
