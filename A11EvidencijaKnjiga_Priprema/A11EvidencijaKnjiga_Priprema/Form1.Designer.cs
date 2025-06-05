namespace A11EvidencijaKnjiga_Priprema
{
    partial class Form1
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
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.dtpDatumR = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aNALIZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAPLIKACIJIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iZLAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpisi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(464, 44);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(253, 22);
            this.txtSifra.TabIndex = 0;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(464, 87);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(253, 22);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(464, 130);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(253, 22);
            this.txtPrezime.TabIndex = 2;
            // 
            // dtpDatumR
            // 
            this.dtpDatumR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumR.Location = new System.Drawing.Point(464, 173);
            this.dtpDatumR.Name = "dtpDatumR";
            this.dtpDatumR.Size = new System.Drawing.Size(253, 22);
            this.dtpDatumR.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNALIZAToolStripMenuItem,
            this.oAPLIKACIJIToolStripMenuItem,
            this.iZLAZToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aNALIZAToolStripMenuItem
            // 
            this.aNALIZAToolStripMenuItem.Name = "aNALIZAToolStripMenuItem";
            this.aNALIZAToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aNALIZAToolStripMenuItem.Text = "ANALIZA";
            this.aNALIZAToolStripMenuItem.Click += new System.EventHandler(this.aNALIZAToolStripMenuItem_Click);
            // 
            // oAPLIKACIJIToolStripMenuItem
            // 
            this.oAPLIKACIJIToolStripMenuItem.Name = "oAPLIKACIJIToolStripMenuItem";
            this.oAPLIKACIJIToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.oAPLIKACIJIToolStripMenuItem.Text = "O APLIKACIJI";
            // 
            // iZLAZToolStripMenuItem
            // 
            this.iZLAZToolStripMenuItem.Name = "iZLAZToolStripMenuItem";
            this.iZLAZToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.iZLAZToolStripMenuItem.Text = "IZLAZ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 345);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(366, 209);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(731, 252);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(873, 44);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 46);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpisi
            // 
            this.btnUpisi.Location = new System.Drawing.Point(873, 96);
            this.btnUpisi.Name = "btnUpisi";
            this.btnUpisi.Size = new System.Drawing.Size(125, 46);
            this.btnUpisi.TabIndex = 8;
            this.btnUpisi.Text = "UPISI";
            this.btnUpisi.UseVisualStyleBackColor = true;
            this.btnUpisi.Click += new System.EventHandler(this.btnUpisi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(873, 148);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(125, 46);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 520);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUpisi);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpDatumR);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.DateTimePicker dtpDatumR;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aNALIZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAPLIKACIJIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iZLAZToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpisi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

