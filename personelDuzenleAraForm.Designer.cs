namespace YurtOtomasyonu
{
    partial class personelDuzenleAraForm
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(76, 312);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(86, 31);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Ara";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(49, 227);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(102, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Adı veya Soyadı";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(49, 254);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(142, 23);
            this.metroTextBox2.TabIndex = 15;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(49, 159);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "TCKNO";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Gorevi";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(49, 186);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(142, 23);
            this.metroTextBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mutfak",
            "Temizlik",
            "Muhasebe",
            "Diger"});
            this.comboBox1.Location = new System.Drawing.Point(49, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // personelDuzenleAraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 408);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroButton1);
            this.Name = "personelDuzenleAraForm";
            this.Text = "UGUR DORM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}