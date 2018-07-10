namespace YurtOtomasyonu
{
    partial class finansSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finansSayfasi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.metroButton3);
            this.panel1.Controls.Add(this.metroButton2);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Location = new System.Drawing.Point(1, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 478);
            this.panel1.TabIndex = 0;
            // 
            // metroButton3
            // 
            this.metroButton3.Highlight = true;
            this.metroButton3.Location = new System.Drawing.Point(153, 308);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(120, 86);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Rapor";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(329, 196);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(120, 86);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Gider Ekle";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(85, 142);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(120, 86);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Odeme Al";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // finansSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 500);
            this.Controls.Add(this.panel1);
            this.Name = "finansSayfasi";
            this.Text = "UGUR DORM";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}