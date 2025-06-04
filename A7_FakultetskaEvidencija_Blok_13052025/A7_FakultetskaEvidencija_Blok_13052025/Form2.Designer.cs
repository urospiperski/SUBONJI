namespace A7_FakultetskaEvidencija_Blok_13052025
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPredmetID = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtPredmet = new System.Windows.Forms.TextBox();
            this.txtSemestar = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPredmetID
            // 
            this.txtPredmetID.Location = new System.Drawing.Point(111, 32);
            this.txtPredmetID.Name = "txtPredmetID";
            this.txtPredmetID.Size = new System.Drawing.Size(159, 22);
            this.txtPredmetID.TabIndex = 0;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(111, 91);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(159, 22);
            this.txtSifra.TabIndex = 1;
            // 
            // txtPredmet
            // 
            this.txtPredmet.Location = new System.Drawing.Point(111, 150);
            this.txtPredmet.Name = "txtPredmet";
            this.txtPredmet.Size = new System.Drawing.Size(159, 22);
            this.txtPredmet.TabIndex = 2;
            // 
            // txtSemestar
            // 
            this.txtSemestar.Location = new System.Drawing.Point(111, 209);
            this.txtSemestar.Name = "txtSemestar";
            this.txtSemestar.Size = new System.Drawing.Size(159, 22);
            this.txtSemestar.TabIndex = 3;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(111, 268);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(159, 117);
            this.txtOpis.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(722, 258);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(291, 348);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(96, 37);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(907, 348);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(106, 37);
            this.btnIzadji.TabIndex = 7;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 427);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtSemestar);
            this.Controls.Add(this.txtPredmet);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtPredmetID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPredmetID;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtPredmet;
        private System.Windows.Forms.TextBox txtSemestar;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzadji;
    }
}