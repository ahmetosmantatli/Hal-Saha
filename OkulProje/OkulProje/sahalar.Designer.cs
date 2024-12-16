namespace OkulProje
{
    partial class sahalar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSahaAdi = new System.Windows.Forms.Label();
            this.lblSahaNumarasi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSahaAdi
            // 
            this.lblSahaAdi.AutoSize = true;
            this.lblSahaAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSahaAdi.ForeColor = System.Drawing.Color.White;
            this.lblSahaAdi.Location = new System.Drawing.Point(3, 0);
            this.lblSahaAdi.Name = "lblSahaAdi";
            this.lblSahaAdi.Size = new System.Drawing.Size(45, 19);
            this.lblSahaAdi.TabIndex = 0;
            this.lblSahaAdi.Text = "label1";
            // 
            // lblSahaNumarasi
            // 
            this.lblSahaNumarasi.AutoSize = true;
            this.lblSahaNumarasi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSahaNumarasi.Location = new System.Drawing.Point(3, 68);
            this.lblSahaNumarasi.Name = "lblSahaNumarasi";
            this.lblSahaNumarasi.Size = new System.Drawing.Size(47, 19);
            this.lblSahaNumarasi.TabIndex = 1;
            this.lblSahaNumarasi.Text = "label2";
            this.lblSahaNumarasi.Click += new System.EventHandler(this.lblSahaNumarasi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::OkulProje.Properties.Resources.goal_post;
            this.pictureBox1.Location = new System.Drawing.Point(30, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblSahaNumarasi);
            this.panel1.Location = new System.Drawing.Point(3, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 85);
            this.panel1.TabIndex = 3;
            // 
            // sahalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSahaAdi);
            this.Name = "sahalar";
            this.Size = new System.Drawing.Size(184, 115);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblSahaAdi;
        public System.Windows.Forms.Label lblSahaNumarasi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
