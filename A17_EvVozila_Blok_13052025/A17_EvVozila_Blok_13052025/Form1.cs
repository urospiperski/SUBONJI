using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace A17_EvVozila_Blok_13052025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=DESKTOP-HHPNNPS\SQLEXPRESS;Initial Catalog=4EIT_A17_EvidencijaVozila;Integrated Security=True"); /* MM 2 sp*/

        SqlCommand kom = new SqlCommand();

        SqlDataReader dr;

        int id = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = false;
            txtxSifra.Enabled = false;
            btnOdustani.Visible = false;
            PuniLV();
        }
        private void PuniComboModel()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniComboModel", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbModel.DataSource = dt;
            cmbModel.DisplayMember = "Naziv";
            Kon.Close();

        }

        private void PuniComboBoja()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniComboBoja", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbBoja.DataSource = dt;
            cmbBoja.DisplayMember = "Naziv";
            Kon.Close();
            

        }

        private void PuniComboGorivo()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniComboGorivo", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbGorivo.DataSource = dt;
            cmbGorivo.DisplayMember = "Naziv";
            Kon.Close();   
        }
        private void SaLVNakontrole()
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                id = Convert.ToInt32(item.SubItems[0].Text);
                
                txtxSifra.Text = id.ToString();
                txtRegistracija.Text = item.SubItems[1].Text;
                txtGodProd.Text = item.SubItems[2].Text;
                txtKilometraza.Text = item.SubItems[3].Text;
                txtCena.Text = item.SubItems[7].Text;
                cmbModel.Text = item.SubItems[8].Text;
                cmbBoja.Text = item.SubItems[9].Text;
                cmbGorivo.Text = item.SubItems[10].Text;
                
            }

        }
        private void PuniLV()
        {
            listView1.Items.Clear();
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniListBoxView", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                ListViewItem red = new ListViewItem(dr[0].ToString());
                for (int i = 1; i < 11; i++) /* i IDE DO KOLIKO POLJA VRACA PROCEDURA*/
                    red.SubItems.Add(dr[i].ToString());
                listView1.Items.Add(red);
            }
            Kon.Close();
        }

        private void Izmena()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("AzurirajPodatkeVozilo", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Registracija", SqlDbType.VarChar).Value = txtRegistracija.Text.ToString();
            cmd.Parameters.AddWithValue("@GodinaProizvodnje", SqlDbType.Int).Value = txtGodProd.Text.ToString();
            cmd.Parameters.AddWithValue("@Kilometraza", SqlDbType.Int).Value = txtKilometraza.Text.ToString();  
            cmd.Parameters.AddWithValue("@ModelNaziv", SqlDbType.VarChar).Value = cmbModel.Text.ToString();
            cmd.Parameters.AddWithValue("@BojaNaziv", SqlDbType.VarChar).Value = cmbBoja.Text.ToString();
            cmd.Parameters.AddWithValue("@GorivoNaziv", SqlDbType.VarChar).Value = cmbGorivo.Text.ToString();
            cmd.Parameters.AddWithValue("@Cena", SqlDbType.Money).Value = txtCena.Text.ToString();
            cmd.Parameters.AddWithValue("@VoziloID", SqlDbType.Int).Value = txtxSifra.Text.ToString();

            cmd.ExecuteNonQuery();

            Kon.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaLVNakontrole();
        }

        private void btnPriprema_Click(object sender, EventArgs e)
        {
            PuniComboModel();
            PuniComboBoja();
            PuniComboGorivo();  

            btnOdustani.Visible = true;
            listView1.FullRowSelect = true;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            listView1.FullRowSelect=false;
            PrazniKontrole();  
        }

        private void PrazniKontrole()
        { 
            txtxSifra.Clear();
            txtRegistracija.Clear();
            txtKilometraza.Clear();
            txtGodProd.Clear();
            txtCena.Clear();

            cmbModel.Text = string.Empty;
            cmbBoja.Text = string.Empty;
            cmbGorivo.Text = string.Empty;
        
        }

        private void iZMENIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izmena();
            PuniLV();
            PrazniKontrole();
            btnOdustani.Visible=false;
            listView1.FullRowSelect=false;
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
