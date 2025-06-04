using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace A10_RibolovackoDrustvo_Priprema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=URKE\SQLEXPRESS;Initial Catalog=4EIT_A10_RibolovackoDrustvo;Integrated Security=True"); /* MM 2 sp*/

        SqlCommand kom = new SqlCommand();

        SqlDataReader dr;

        int id = 0;
        private void aNALIZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifra.Enabled= false;
            PuniLV();
            PuniComboGrad();
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
                for (int i = 1; i < 6; i++) /* i IDE DO KOLIKO POLJA VRACA PROCEDURA*/
                    red.SubItems.Add(dr[i].ToString());
                listView1.Items.Add(red);
            }
            Kon.Close();
        }

        private void PuniComboGrad()
        {
            Kon.Open();

            SqlCommand cmd = new SqlCommand("PuniComboGrad", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cmbGrad.DataSource = dt;
            cmbGrad.DisplayMember = "Grad";

            Kon.Close();
        }

        private void SaLVNaKontrole()
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                id = Convert.ToInt32(item.SubItems[0].Text);
                
                txtSifra.Text = id.ToString();
                txtIme.Text = item.SubItems[1].Text;
                txtPrezime.Text = item.SubItems[2].Text;
                txtAdresa.Text = item.SubItems[3].Text;
                cmbGrad.Text = item.SubItems[4].Text;
                txtTelefon.Text = item.SubItems[5].Text;
                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaLVNaKontrole();
        }

        private void Izmena()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("IzmeniUpdatePecaros", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PecarosID", SqlDbType.VarChar).Value = txtSifra.Text.ToString();
            cmd.Parameters.AddWithValue("@Ime", SqlDbType.VarChar).Value = txtIme.Text.ToString();
            cmd.Parameters.AddWithValue("@Prezime", SqlDbType.VarChar).Value = txtPrezime.Text.ToString();
            cmd.Parameters.AddWithValue("@Adresa", SqlDbType.VarChar).Value = txtAdresa.Text.ToString();
            cmd.Parameters.AddWithValue("@Telefon", SqlDbType.VarChar).Value = txtTelefon.Text.ToString();
            cmd.Parameters.AddWithValue("@Grad", SqlDbType.VarChar).Value = cmbGrad.Text.ToString();

            cmd.ExecuteNonQuery();

            Kon.Close();
        }

        private void iZMENAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izmena();
            PuniLV();
        }
    }
}
