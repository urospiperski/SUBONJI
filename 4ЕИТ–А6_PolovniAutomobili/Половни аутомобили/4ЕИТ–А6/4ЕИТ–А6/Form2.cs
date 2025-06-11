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

namespace _4ЕИТ_А6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Kon = new SqlConnection(@"Data Source=DESKTOP-JAQOFEV\SQLEXPRESS;Initial Catalog=4EIT_А6_PolovniAutomobili;Integrated Security=True");
        SqlCommand kom = new SqlCommand();
        SqlDataReader dr;
        int id = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1900;
            numericUpDown1.Maximum = DateTime.Now.Year;
            numericUpDown1.Value = 1900;

            numericUpDown2.Minimum = 1900;
            numericUpDown2.Maximum = DateTime.Now.Year;
            numericUpDown2.Value = DateTime.Now.Year;
        }
        private void PuniGridChart()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PuniGridChart", Kon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@GodisteOD", (int)numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@GodisteDO", (int)numericUpDown2.Value);
                cmd.Parameters.AddWithValue("@Kilometraza", textBox1.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                chart1.Series.Clear();
                chart1.Titles.Clear();

                chart1.Titles.Add("Broj vozila po proizvodjacu");

                var series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Vozila",
                    IsVisibleInLegend = false,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column
                };

                chart1.Series.Add(series);

                foreach (DataRow row in dt.Rows)
                {
                    string proizvodjac = row["Proizvodjac"].ToString();
                    int brojVozila = Convert.ToInt32(row["BrVozila"]);
                    series.Points.AddXY(proizvodjac, brojVozila);
                }

                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chart1.ChartAreas[0].AxisX.Title = "Proizvodjac";
                chart1.ChartAreas[0].AxisY.Title = "Broj vozila";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju podataka: " + ex.Message);
            }
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            PuniGridChart();

        }
    }
}
