namespace YurtOtomasyonu
{
    partial class goruntule
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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(61, 92);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PromptText = "Sorgula";
            this.metroTextBox1.Size = new System.Drawing.Size(135, 23);
            this.metroTextBox1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(171, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "TC Kimlik Numarasını giriniz";
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(87, 132);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Bak Bakalım";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomForeColor = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Red;
            this.metroLabel2.Location = new System.Drawing.Point(23, 221);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(198, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Boyle bir ogrenci kayıtlı degildir!";
            this.metroLabel2.Visible = false;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(72, 174);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(109, 30);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Tumunu Goruntule";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // goruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 260);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Name = "goruntule";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}