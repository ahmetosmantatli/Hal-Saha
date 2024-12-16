namespace OkulProje
{
    partial class frmSahaYonlendirmEkrani
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
            this.PnlUstMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Kapat = new System.Windows.Forms.Button();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.SahaListePaneli = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlUstMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlUstMenu
            // 
            this.PnlUstMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PnlUstMenu.Controls.Add(this.label1);
            this.PnlUstMenu.Controls.Add(this.Btn_Kapat);
            this.PnlUstMenu.Controls.Add(this.PnlLogo);
            this.PnlUstMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUstMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlUstMenu.Name = "PnlUstMenu";
            this.PnlUstMenu.Size = new System.Drawing.Size(581, 60);
            this.PnlUstMenu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "[YÖNLENDİRME EKRANI]";
            // 
            // Btn_Kapat
            // 
            this.Btn_Kapat.BackColor = System.Drawing.Color.MediumPurple;
            this.Btn_Kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Kapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Kapat.FlatAppearance.BorderSize = 0;
            this.Btn_Kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Kapat.ForeColor = System.Drawing.Color.White;
            this.Btn_Kapat.Location = new System.Drawing.Point(541, 0);
            this.Btn_Kapat.Name = "Btn_Kapat";
            this.Btn_Kapat.Size = new System.Drawing.Size(40, 60);
            this.Btn_Kapat.TabIndex = 1;
            this.Btn_Kapat.Text = "X";
            this.Btn_Kapat.UseVisualStyleBackColor = false;
            this.Btn_Kapat.Click += new System.EventHandler(this.Btn_Kapat_Click);
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
            // SahaListePaneli
            // 
            this.SahaListePaneli.AutoScroll = true;
            this.SahaListePaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SahaListePaneli.Location = new System.Drawing.Point(0, 60);
            this.SahaListePaneli.Name = "SahaListePaneli";
            this.SahaListePaneli.Size = new System.Drawing.Size(581, 245);
            this.SahaListePaneli.TabIndex = 3;
            this.SahaListePaneli.Paint += new System.Windows.Forms.PaintEventHandler(this.SahaListePaneli_Paint);
            // 
            // frmSahaYonlendirmEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(581, 305);
            this.Controls.Add(this.SahaListePaneli);
            this.Controls.Add(this.PnlUstMenu);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSahaYonlendirmEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSahaYonlendirmEkrani";
            this.Activated += new System.EventHandler(this.frmSahaYonlendirmEkrani_Activated);
            this.Load += new System.EventHandler(this.frmSahaYonlendirmEkrani_Load);
            this.PnlUstMenu.ResumeLayout(false);
            this.PnlUstMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlUstMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Kapat;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.FlowLayoutPanel SahaListePaneli;
    }
}