namespace YurtOtomasyonu
{
    partial class personeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personeller));
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.metroButton4);
            this.panel1.Controls.Add(this.metroButton3);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 599);
            this.panel1.TabIndex = 0;
            // 
            // metroButton4
            // 
            this.metroButton4.Highlight = true;
            this.metroButton4.Location = new System.Drawing.Point(215, 380);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(137, 76);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "Personelleri Duzenle";
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(32, 236);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(137, 76);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Personelleri Goruntule";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(265, 139);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(137, 76);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Personel Sil";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(42, 38);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(144, 82);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Personel Ekle";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 664);
            this.Controls.Add(this.panel1);
            this.Name = "personeller";
            this.Text = "Ugur Dorm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
    }
}