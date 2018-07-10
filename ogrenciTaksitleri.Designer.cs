namespace YurtOtomasyonu
{
    partial class ogrenciTaksitleri
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
            this.ogrSayilbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // ogrSayilbl
            // 
            this.ogrSayilbl.AutoSize = true;
            this.ogrSayilbl.Location = new System.Drawing.Point(207, 93);
            this.ogrSayilbl.Name = "ogrSayilbl";
            this.ogrSayilbl.Size = new System.Drawing.Size(138, 19);
            this.ogrSayilbl.TabIndex = 0;
            this.ogrSayilbl.Text = "Toplam Ogrenci Sayısı";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(138, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Toplam Ogrenci Sayısı";
            // 
            // ogrenciTaksitleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 686);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ogrSayilbl);
            this.Name = "ogrenciTaksitleri";
            this.Text = "Ugur Dorm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ogrSayilbl;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}