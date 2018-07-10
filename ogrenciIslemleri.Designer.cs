namespace YurtOtomasyonu
{
    partial class ogrenciIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciIslemleri));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(82, 32);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(139, 74);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Ogrenci Kaydet";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(46, 190);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(139, 93);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Ogrenci Goruntule";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(17, 381);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(141, 75);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "İzin Ver";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Highlight = true;
            this.metroButton4.Location = new System.Drawing.Point(250, 119);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(151, 85);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "Ogrenci Duzenle";
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.metroButton6);
            this.panel1.Controls.Add(this.metroButton5);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.metroButton4);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.metroButton3);
            this.panel1.Location = new System.Drawing.Point(6, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 651);
            this.panel1.TabIndex = 4;
            // 
            // metroButton6
            // 
            this.metroButton6.Highlight = true;
            this.metroButton6.Location = new System.Drawing.Point(237, 436);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(135, 91);
            this.metroButton6.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroButton6.TabIndex = 5;
            this.metroButton6.Text = "İzin Takip";
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Highlight = true;
            this.metroButton5.Location = new System.Drawing.Point(228, 270);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(158, 88);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton5.TabIndex = 4;
            this.metroButton5.Text = "Ogrenci Kaydını Sil";
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // ogrenciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 737);
            this.Controls.Add(this.panel1);
            this.Name = "ogrenciIslemleri";
            this.Text = "UGUR DORM";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton5;
    }
}