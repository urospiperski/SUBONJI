using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace _4EIT_A16_IzlozbaPasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Kon=new SqlConnection(@"Data Source=URKE\SQLEXPRESS;Initial Catalog=4EIT_A16_IzlozbaPasa;Integrated Security=True");
        SqlCommand kom=new SqlCommand();
        SqlDataReader dr;
        int id = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Unesi prijavu";
            tabPage2.Text = "Statistika";
            tabPage3.Text = "O aplikaciji";
            tabPage4.Text = "Izlaz";
            punicomboPas();
            punicomboIzlozba();
            punicomboKategorija();
          
        }
        private void punicomboPas()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniComboPas", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
          
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Pas";
            Kon.Close();
        }

        private void punicomboIzlozba()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniComboIzlozba", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
          
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "Izlozba";
            Kon.Close();
        }

        private void punicomboKategorija()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("PuniComboKategorija", Kon);
            cmd.CommandType = CommandType.StoredProcedure;
            
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Kategorija";
            Kon.Close();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            PrijaviPsa();
        }

        private void Provera()
        {
            Kon.Open();

            string Pas = comboBox1.Text.ToString();
            string[] PasID = Pas.Split('-');
            string Izlozba = comboBox2.Text.ToString();
            string[] IzlozbaID = Izlozba.Split('-');
            string Kategorija = comboBox3.Text.ToString();
            string[] KategorijaID = Kategorija.Split('-');

            SqlCommand cmd = new SqlCommand("Provera", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzlozbaID", SqlDbType.NVarChar).Value = IzlozbaID[0];
            cmd.Parameters.AddWithValue("@KategorijaID", SqlDbType.Int).Value = Convert.ToInt32(KategorijaID[0]);
            cmd.Parameters.AddWithValue("@PasID", SqlDbType.Int).Value = Convert.ToInt32(PasID[0]);

            string Pass = "";
            string Izlozbaa = "";
            string Kategorijaa = "";

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pass = dr[2].ToString().Trim();
                Izlozbaa = dr[0].ToString().Trim();
                Kategorijaa = dr[1].ToString().Trim();
            }

            Kon.Close();

            if (PasID[0].Trim() == Pass && IzlozbaID[0].Trim() == Izlozbaa && KategorijaID[0].Trim() == Kategorijaa)
            {
                MessageBox.Show("Vec ste se prijavili", "Greska");
            }
            else
            {
                PrijaviPsa();
            }
        }

        private void PrijaviPsa()
        {
            Kon.Open();

            string Pas = comboBox1.Text.ToString();
            string[] PasID = Pas.Split('-');
            string Izlozba = comboBox2.Text.ToString();
            string[] IzlozbaID = Izlozba.Split('-');
            string Kategorija = comboBox3.Text.ToString();
            string[] KategorijaID = Kategorija.Split('-');

            SqlCommand cmd = new SqlCommand("PrijavaPasa", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzlozbaID", SqlDbType.NVarChar).Value = IzlozbaID[0];
            cmd.Parameters.AddWithValue("@KategorijaID", SqlDbType.Int).Value = Convert.ToInt32(KategorijaID[0]);
            cmd.Parameters.AddWithValue("@PasID", SqlDbType.Int).Value = Convert.ToInt32(PasID[0]);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Uspesno ste se prijavili!");
            Kon.Close();
        }
        private void PuniComboIzlozba2()
        {
            Kon.Open();

            SqlCommand cmd = new SqlCommand("PuniComboIzlozba", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "Izlozba";

            Kon.Close();
        }
        private void PuniGridIChart()
        {
            chart1.Titles.Clear();
            string Izlozba = comboBox4.Text.ToString();
            string[] IzlozbaID = Izlozba.Split('-');
            Kon.Open();

            SqlCommand cmd = new SqlCommand("PuniGridIChart", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzlozbaID", SqlDbType.NVarChar).Value = IzlozbaID[0];

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            dataGridView1.DataSource = dt;
            chart1.DataSource = dt;

            chart1.Series["Series1"].XValueMember = "Naziv";
            chart1.Series["Series1"].YValueMembers = "BrojPasa";
            chart1.Titles.Add("Broj pasa koji se takmicio");

            Kon.Close();
        }

        private void UkupanPrijavljen()
        {
            Kon.Open();

            string Izlozba = comboBox4.Text.ToString();
            string[] IzlozbaID = Izlozba.Split('-');

            SqlCommand cmd = new SqlCommand("UkupanBrPrijavljenih", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzlozbaID", SqlDbType.NVarChar).Value = IzlozbaID[0];

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label5.Text = "Ukupan broj pasa koji je prijavljen : " + dr[0].ToString();
            }

            Kon.Close();
        }

        private void UkupanTakmicen()
        {
            Kon.Open();

            string Izlozba = comboBox4.Text.ToString();
            string[] IzlozbaID = Izlozba.Split('-');

            SqlCommand cmd = new SqlCommand("UkupanBrKojiSeTakmicio", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IzlozbaID", SqlDbType.NVarChar).Value = IzlozbaID[0];

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label6.Text = "Ukupan broj pasa koji se takmicio : " + dr[0].ToString();
            }

            Kon.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            PuniGridIChart();
            UkupanPrijavljen();
            UkupanTakmicen();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            PuniComboIzlozba2();
        }
    }
}
