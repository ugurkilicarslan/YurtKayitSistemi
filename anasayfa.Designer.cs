namespace YurtOtomasyonu
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(291, 280);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(124, 194);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Oda Bilgileri";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(157, 280);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(128, 194);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Ogrenci İşlemleri";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(421, 280);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(128, 194);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Finansal Durum";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Highlight = true;
            this.metroButton4.Location = new System.Drawing.Point(247, 517);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(224, 89);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroButton4.TabIndex = 3;
            this.metroButton4.Text = "Hizmet Durumu";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Highlight = true;
            this.metroButton5.Location = new System.Drawing.Point(247, 639);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(224, 105);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton5.TabIndex = 4;
            this.metroButton5.Text = "Personeller";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.metroButton4);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.metroButton5);
            this.panel1.Controls.Add(this.metroButton3);
            this.panel1.Location = new System.Drawing.Point(1, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 788);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(291, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 25);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "UGUR DORM";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 816);
            this.Controls.Add(this.panel1);
            this.Name = "anasayfa";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = " UGUR DORM";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}