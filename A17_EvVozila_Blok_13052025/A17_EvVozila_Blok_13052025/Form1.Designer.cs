namespace A17_EvVozila_Blok_13052025
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
            this.groupOpsti = new System.Windows.Forms.GroupBox();
            this.groupDodatni = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iZMENIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNALIZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAPLIKACIJIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iZLAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnPriprema = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtxSifra = new System.Windows.Forms.TextBox();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.txtGodProd = new System.Windows.Forms.TextBox();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbBoja = new System.Windows.Forms.ComboBox();
            this.cmbGorivo = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupOpsti.SuspendLayout();
            this.groupDodatni.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupOpsti
            // 
            this.groupOpsti.Controls.Add(this.txtCena);
            this.groupOpsti.Controls.Add(this.txtKilometraza);
            this.groupOpsti.Controls.Add(this.txtGodProd);
            this.groupOpsti.Controls.Add(this.txtRegistracija);
            this.groupOpsti.Controls.Add(this.txtxSifra);
            this.groupOpsti.Location = new System.Drawing.Point(33, 51);
            this.groupOpsti.Name = "groupOpsti";
            this.groupOpsti.Size = new System.Drawing.Size(387, 215);
            this.groupOpsti.TabIndex = 0;
            this.groupOpsti.TabStop = false;
            this.groupOpsti.Text = "OPSTI PODACI";
            // 
            // groupDodatni
            // 
            this.groupDodatni.Controls.Add(this.cmbGorivo);
            this.groupDodatni.Controls.Add(this.cmbBoja);
            this.groupDodatni.Controls.Add(this.cmbModel);
            this.groupDodatni.Location = new System.Drawing.Point(483, 66);
            this.groupDodatni.Name = "groupDodatni";
            this.groupDodatni.Size = new System.Drawing.Size(387, 148);
            this.groupDodatni.TabIndex = 1;
            this.groupDodatni.TabStop = false;
            this.groupDodatni.Text = "DODATNI PODACI";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iZMENIToolStripMenuItem,
            this.aNALIZAToolStripMenuItem,
            this.oAPLIKACIJIToolStripMenuItem,
            this.iZLAZToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iZMENIToolStripMenuItem
            // 
            this.iZMENIToolStripMenuItem.Name = "iZMENIToolStripMenuItem";
            this.iZMENIToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.iZMENIToolStripMenuItem.Text = "IZMENI";
            this.iZMENIToolStripMenuItem.Click += new System.EventHandler(this.iZMENIToolStripMenuItem_Click);
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
            this.oAPLIKACIJIToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.oAPLIKACIJIToolStripMenuItem.Text = "O APLIKACIJI";
            // 
            // iZLAZToolStripMenuItem
            // 
            this.iZLAZToolStripMenuItem.Name = "iZLAZToolStripMenuItem";
            this.iZLAZToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.iZLAZToolStripMenuItem.Text = "IZLAZ";
            this.iZLAZToolStripMenuItem.Click += new System.EventHandler(this.iZLAZToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(33, 272);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(837, 240);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnPriprema
            // 
            this.btnPriprema.Location = new System.Drawing.Point(483, 220);
            this.btnPriprema.Name = "btnPriprema";
            this.btnPriprema.Size = new System.Drawing.Size(159, 46);
            this.btnPriprema.TabIndex = 4;
            this.btnPriprema.Text = "PRIPREMA ZA IZMENU";
            this.btnPriprema.UseVisualStyleBackColor = true;
            this.btnPriprema.Click += new System.EventHandler(this.btnPriprema_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "sifra";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Registracija";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "GodinaPr";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "PredjenoKM";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ModelID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "BojaID";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "GorivoID";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cena";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Model";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Boja";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Gorivo";
            this.columnHeader11.Width = 100;
            // 
            // txtxSifra
            // 
            this.txtxSifra.Location = new System.Drawing.Point(75, 31);
            this.txtxSifra.Name = "txtxSifra";
            this.txtxSifra.Size = new System.Drawing.Size(158, 22);
            this.txtxSifra.TabIndex = 0;
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(75, 65);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(158, 22);
            this.txtRegistracija.TabIndex = 1;
            // 
            // txtGodProd
            // 
            this.txtGodProd.Location = new System.Drawing.Point(75, 99);
            this.txtGodProd.Name = "txtGodProd";
            this.txtGodProd.Size = new System.Drawing.Size(158, 22);
            this.txtGodProd.TabIndex = 2;
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(75, 133);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(158, 22);
            this.txtKilometraza.TabIndex = 3;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(75, 167);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(158, 22);
            this.txtCena.TabIndex = 4;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(162, 35);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(181, 24);
            this.cmbModel.TabIndex = 0;
            // 
            // cmbBoja
            // 
            this.cmbBoja.FormattingEnabled = true;
            this.cmbBoja.Location = new System.Drawing.Point(162, 70);
            this.cmbBoja.Name = "cmbBoja";
            this.cmbBoja.Size = new System.Drawing.Size(181, 24);
            this.cmbBoja.TabIndex = 1;
            // 
            // cmbGorivo
            // 
            this.cmbGorivo.FormattingEnabled = true;
            this.cmbGorivo.Location = new System.Drawing.Point(162, 105);
            this.cmbGorivo.Name = "cmbGorivo";
            this.cmbGorivo.Size = new System.Drawing.Size(181, 24);
            this.cmbGorivo.TabIndex = 2;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(711, 220);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(159, 46);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 524);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPriprema);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupDodatni);
            this.Controls.Add(this.groupOpsti);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupOpsti.ResumeLayout(false);
            this.groupOpsti.PerformLayout();
            this.groupDodatni.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupOpsti;
        private System.Windows.Forms.GroupBox groupDodatni;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iZMENIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNALIZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAPLIKACIJIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iZLAZToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnPriprema;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.TextBox txtGodProd;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.TextBox txtxSifra;
        private System.Windows.Forms.ComboBox cmbGorivo;
        private System.Windows.Forms.ComboBox cmbBoja;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnOdustani;
    }
}

