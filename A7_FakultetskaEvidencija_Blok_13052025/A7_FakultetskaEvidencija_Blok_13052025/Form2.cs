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
using System.Windows.Forms.DataVisualization.Charting;

namespace A7_FakultetskaEvidencija_Blok_13052025
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=DESKTOP-HHPNNPS\SQLEXPRESS;Initial Catalog=4EIT_A7_FakultetskaEvidencija;Integrated Security=True"); /* MM 2 sp*/

        SqlCommand kom = new SqlCommand();

        SqlDataReader dr;

        int id = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            PuniGrid();
        }

        private void Brisi()
        {

            Kon.Open();
            SqlCommand cmd = new SqlCommand("BrisiPredmet", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@PredmetID", SqlDbType.VarChar).Value = txtPredmetID.Text.ToString();

            cmd.ExecuteNonQuery();

            Kon.Close();

        }
        private void PuniGrid()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniGrid", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            dataGridView1.DataSource = dt;

            
            Kon.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtPredmetID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSifra.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPredmet.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSemestar.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtOpis.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Brisi();
            PuniGrid();
        }
    }
}
