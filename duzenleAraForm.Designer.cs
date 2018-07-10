namespace YurtOtomasyonu
{
    partial class duzenleAraForm
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(45, 169);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(90, 37);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Oda Degistir";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(164, 169);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(90, 37);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Diger";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(67, 104);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(167, 23);
            this.metroTextBox1.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(63, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(171, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "TC Kimlik Numarasını giriniz";
            // 
            // duzenleAraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 273);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Name = "duzenleAraForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}