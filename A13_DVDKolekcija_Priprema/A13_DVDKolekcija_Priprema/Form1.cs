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

namespace A13_DVDKolekcija_Priprema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=DESKTOP-HHPNNPS\SQLEXPRESS;Initial Catalog=4EIT_A13_DVDKolekcija;Integrated Security=True"); /* MM 2 sp*/

        SqlCommand kom = new SqlCommand();

        SqlDataReader dr;

        int id = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifra.Enabled = false;
            listView1.FullRowSelect = true;
            PuniLV();
        }

        private void PuniLV()
        {
            listView1.Items.Clear();
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniListView", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                ListViewItem red = new ListViewItem(dr[0].ToString());
                for (int i = 1; i < 3; i++) /* i IDE DO KOLIKO POLJA VRACA PROCEDURA*/
                    red.SubItems.Add(dr[i].ToString());
                listView1.Items.Add(red);
            }
            Kon.Close();

        }

        private void SaLVNaKontrole()
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                id = Convert.ToInt32(item.SubItems[0].Text);
                
                txtSifra.Text = id.ToString();
                txtNaziv.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaLVNaKontrole();
        }

        private void Izmena()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("IzmeniUpdate", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ProducentID", SqlDbType.VarChar).Value = txtSifra.Text.ToString();
            cmd.Parameters.AddWithValue("@Ime", SqlDbType.VarChar).Value = txtNaziv.Text.ToString();
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = txtEmail.Text.ToString();

            cmd.ExecuteNonQuery();

            Kon.Close();
        }

        private void iZMENIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izmena();
            MessageBox.Show("USPESNA IZMENA");
            PrazniKontrole();
            PuniLV();

        }

        private void PrazniKontrole()
        { 
            txtSifra.Clear();
            txtNaziv.Clear();
            txtEmail.Clear();

        }

        private void aNALIZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void iZLAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
