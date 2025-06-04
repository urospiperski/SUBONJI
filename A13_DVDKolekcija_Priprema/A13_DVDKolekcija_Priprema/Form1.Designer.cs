namespace A13_DVDKolekcija_Priprema
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iZMENIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNALIZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAPLIKACIJIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iZLAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
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
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(171, 69);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(209, 22);
            this.txtSifra.TabIndex = 1;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(171, 108);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(209, 22);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(171, 145);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(171, 199);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(588, 205);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sifra";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naziv producentske kuce";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iZMENIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNALIZAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAPLIKACIJIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iZLAZToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

