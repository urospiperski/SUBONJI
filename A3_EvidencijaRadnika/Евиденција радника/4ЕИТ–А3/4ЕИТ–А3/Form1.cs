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

namespace _4ЕИТ_А3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Kon= new SqlConnection(@"Data Source=DESKTOP-JAQOFEV\SQLEXPRESS;Initial Catalog=EIT_A03_EvidencijaRadnika;Integrated Security=True");
        SqlCommand kom = new SqlCommand();
        SqlDataReader dr;
        int id = 0;

        private void pregledProjektaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
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
                for (int i = 1; i < 6; i++) /* i IDE DO KOLIKO POLJA VRACA PROCEDURA*/
                    red.SubItems.Add(dr[i].ToString());
                listView1.Items.Add(red);
            }
            Kon.Close();
        }

        private void SaLVNakontrole()
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                id = Convert.ToInt32(item.SubItems[0].Text);

                textBox1.Text = id.ToString();
                textBox2.Text = item.SubItems[1].Text;
                textBox3.Text = item.SubItems[2].Text;
                textBox4.Text = item.SubItems[4].Text;
                switch (item.SubItems[3].Text)
                {
                    case "true":
                        checkBox1.Checked = true;
                        break;
                    case "false":
                        checkBox1.Checked = false;
                        break;
                }

            }

        }

        private void brisiProjekat()
        {
            Kon.Open();
            SqlCommand cmd = new SqlCommand("BrisiProjekat", Kon);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SifraProjekta", SqlDbType.VarChar).Value = textBox1.Text.ToString();

            cmd.ExecuteNonQuery();

            Kon.Close();
        }
        private void praznikontrole()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            puniLV();
            textBox1.Enabled = false;
            listView1.Enabled = true;
            listView1.FullRowSelect = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaLVNakontrole();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Zelite da obrisete radnika?";
            string naslov = "Brisanje radnika";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(poruka, naslov, buttons);

            if (result == DialogResult.Yes)
            {
                brisiProjekat();
            }

            puniLV();
            praznikontrole();
        }
    }
}
