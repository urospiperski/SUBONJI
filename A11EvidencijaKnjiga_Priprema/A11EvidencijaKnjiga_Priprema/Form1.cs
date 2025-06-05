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

namespace A11EvidencijaKnjiga_Priprema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=DESKTOP-HHPNNPS\SQLEXPRESS;Initial Catalog=4EIT_A11_EvidencijaKnjiga;Integrated Security=True"); /* MM 2 sp*/

        SqlCommand kom = new SqlCommand();

        SqlDataReader dr;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtSifra.Enabled = false;
            btnOdustani.Enabled = false;
            btnUpisi.Enabled = false;
            PuniLV();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnOdustani.Enabled = true;
            btnUpisi.Enabled = true;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            btnOdustani.Enabled = false;
            btnUpisi.Enabled = false;
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
                for (int i = 1; i < 4; i++) /* i IDE DO KOLIKO POLJA VRACA PROCEDURA*/
                    red.SubItems.Add(dr[i].ToString());
                listView1.Items.Add(red);
            }
            Kon.Close();
        }

        private void Unos()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("InsertAutor", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ImeAutora", SqlDbType.VarChar).Value = txtIme.Text.ToString();
            cmd.Parameters.AddWithValue("@PrezimeAutora", SqlDbType.VarChar).Value = txtPrezime.Text.ToString();
            cmd.Parameters.AddWithValue("@DatumRodjena", SqlDbType.Date).Value = dtpDatumR.Value;

            cmd.ExecuteNonQuery();

            Kon.Close();
        }

        private void btnUpisi_Click(object sender, EventArgs e)
        {
            Unos();
            PuniLV();
            MessageBox.Show("uspesno");
            btnOdustani.Enabled = false;
            btnUpisi.Enabled = false;

        }

        private void aNALIZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
