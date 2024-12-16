namespace OkulProje
{
    partial class frmSahaListesi
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
            this.PnlSol = new System.Windows.Forms.Panel();
            this.SahaListePaneli = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlUstMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PnlSag = new System.Windows.Forms.Panel();
            this.PnlMesaj = new System.Windows.Forms.Panel();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.PnlAramaMenu = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Kapat = new System.Windows.Forms.Button();
            this.PnlSol.SuspendLayout();
            this.PnlUstMenu.SuspendLayout();
            this.PnlSag.SuspendLayout();
            this.PnlMesaj.SuspendLayout();
            this.PnlAramaMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSol
            // 
            this.PnlSol.BackColor = System.Drawing.Color.White;
            this.PnlSol.Controls.Add(this.SahaListePaneli);
            this.PnlSol.Controls.Add(this.PnlUstMenu);
            this.PnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSol.Location = new System.Drawing.Point(0, 0);
            this.PnlSol.Name = "PnlSol";
            this.PnlSol.Size = new System.Drawing.Size(692, 505);
            this.PnlSol.TabIndex = 0;
            // 
            // SahaListePaneli
            // 
            this.SahaListePaneli.AutoScroll = true;
            this.SahaListePaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SahaListePaneli.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SahaListePaneli.Location = new System.Drawing.Point(0, 60);
            this.SahaListePaneli.Name = "SahaListePaneli";
            this.SahaListePaneli.Size = new System.Drawing.Size(692, 445);
            this.SahaListePaneli.TabIndex = 4;
            this.SahaListePaneli.Paint += new System.Windows.Forms.PaintEventHandler(this.SahaListePaneli_Paint);
            // 
            // PnlUstMenu
            // 
            this.PnlUstMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlUstMenu.Controls.Add(this.label1);
            this.PnlUstMenu.Controls.Add(this.PnlLogo);
            this.PnlUstMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUstMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlUstMenu.Name = "PnlUstMenu";
            this.PnlUstMenu.Size = new System.Drawing.Size(692, 60);
            this.PnlUstMenu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "[SAHA LİSTE EKRANI]";
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackColor = System.Drawing.Color.MediumPurple;
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(20, 60);
            this.PnlLogo.TabIndex = 0;
            // 
            // PnlSag
            // 
            this.PnlSag.BackColor = System.Drawing.SystemColors.Control;
            this.PnlSag.Controls.Add(this.PnlMesaj);
            this.PnlSag.Controls.Add(this.PnlAramaMenu);
            this.PnlSag.Controls.Add(this.panel1);
            this.PnlSag.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlSag.Location = new System.Drawing.Point(711, 0);
            this.PnlSag.Name = "PnlSag";
            this.PnlSag.Size = new System.Drawing.Size(200, 505);
            this.PnlSag.TabIndex = 1;
            // 
            // PnlMesaj
            // 
            this.PnlMesaj.BackColor = System.Drawing.SystemColors.Control;
            this.PnlMesaj.Controls.Add(this.lblMesaj);
            this.PnlMesaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMesaj.ForeColor = System.Drawing.Color.Black;
            this.PnlMesaj.Location = new System.Drawing.Point(0, 160);
            this.PnlMesaj.Name = "PnlMesaj";
            this.PnlMesaj.Size = new System.Drawing.Size(200, 100);
            this.PnlMesaj.TabIndex = 5;
            // 
            // lblMesaj
            // 
            this.lblMesaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMesaj.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.ForeColor = System.Drawing.Color.White;
            this.lblMesaj.Location = new System.Drawing.Point(0, 0);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(200, 100);
            this.lblMesaj.TabIndex = 1;
            this.lblMesaj.Text = "label1";
            this.lblMesaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlAramaMenu
            // 
            this.PnlAramaMenu.BackColor = System.Drawing.Color.White;
            this.PnlAramaMenu.Controls.Add(this.groupBox1);
            this.PnlAramaMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlAramaMenu.Location = new System.Drawing.Point(0, 60);
            this.PnlAramaMenu.Name = "PnlAramaMenu";
            this.PnlAramaMenu.Size = new System.Drawing.Size(200, 100);
            this.PnlAramaMenu.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(7, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 69);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.ForeColor = System.Drawing.Color.MediumPurple;
            this.txtSearch.Location = new System.Drawing.Point(3, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(175, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Btn_Kapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 60);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "[ARAMA YAP]";
            // 
            // Btn_Kapat
            // 
            this.Btn_Kapat.BackColor = System.Drawing.Color.MediumPurple;
            this.Btn_Kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Kapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Kapat.FlatAppearance.BorderSize = 0;
            this.Btn_Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Kapat.ForeColor = System.Drawing.Color.White;
            this.Btn_Kapat.Location = new System.Drawing.Point(160, 0);
            this.Btn_Kapat.Name = "Btn_Kapat";
            this.Btn_Kapat.Size = new System.Drawing.Size(40, 60);
            this.Btn_Kapat.TabIndex = 1;
            this.Btn_Kapat.Text = "X";
            this.Btn_Kapat.UseVisualStyleBackColor = false;
            this.Btn_Kapat.Click += new System.EventHandler(this.Btn_Kapat_Click);
            // 
            // frmSahaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 505);
            this.Controls.Add(this.PnlSag);
            this.Controls.Add(this.PnlSol);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSahaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSahaListesi";
            this.Activated += new System.EventHandler(this.frmSahaListesi_Activated);
            this.Load += new System.EventHandler(this.frmSahaListesi_Load);
            this.PnlSol.ResumeLayout(false);
            this.PnlUstMenu.ResumeLayout(false);
            this.PnlUstMenu.PerformLayout();
            this.PnlSag.ResumeLayout(false);
            this.PnlMesaj.ResumeLayout(false);
            this.PnlAramaMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSol;
        private System.Windows.Forms.Panel PnlSag;
        private System.Windows.Forms.Panel PnlUstMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Kapat;
        private System.Windows.Forms.Panel PnlAramaMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel PnlMesaj;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.FlowLayoutPanel SahaListePaneli;
    }
}