namespace YurtOtomasyonu
{
    partial class giderler
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mutfak",
            "Temizlik",
            "Muhasebe",
            "Diger"});
            this.comboBox1.Location = new System.Drawing.Point(53, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(53, 183);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(176, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(91, 254);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Gider Ekle";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 362);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "giderler";
            this.Text = "UGUR DORM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}