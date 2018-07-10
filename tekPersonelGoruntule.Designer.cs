namespace YurtOtomasyonu
{
    partial class tekPersonelGoruntule
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aditxt = new MetroFramework.Controls.MetroLabel();
            this.tckNotxt = new MetroFramework.Controls.MetroLabel();
            this.telefontxt = new MetroFramework.Controls.MetroLabel();
            this.gorevitxt = new MetroFramework.Controls.MetroLabel();
            this.maasitxt = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(103, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // aditxt
            // 
            this.aditxt.AutoSize = true;
            this.aditxt.Location = new System.Drawing.Point(125, 252);
            this.aditxt.Name = "aditxt";
            this.aditxt.Size = new System.Drawing.Size(81, 19);
            this.aditxt.TabIndex = 1;
            this.aditxt.Text = "metroLabel1";
            // 
            // tckNotxt
            // 
            this.tckNotxt.AutoSize = true;
            this.tckNotxt.Location = new System.Drawing.Point(125, 288);
            this.tckNotxt.Name = "tckNotxt";
            this.tckNotxt.Size = new System.Drawing.Size(83, 19);
            this.tckNotxt.TabIndex = 2;
            this.tckNotxt.Text = "metroLabel2";
            // 
            // telefontxt
            // 
            this.telefontxt.AutoSize = true;
            this.telefontxt.Location = new System.Drawing.Point(125, 328);
            this.telefontxt.Name = "telefontxt";
            this.telefontxt.Size = new System.Drawing.Size(83, 19);
            this.telefontxt.TabIndex = 3;
            this.telefontxt.Text = "metroLabel3";
            // 
            // gorevitxt
            // 
            this.gorevitxt.AutoSize = true;
            this.gorevitxt.Location = new System.Drawing.Point(125, 371);
            this.gorevitxt.Name = "gorevitxt";
            this.gorevitxt.Size = new System.Drawing.Size(83, 19);
            this.gorevitxt.TabIndex = 4;
            this.gorevitxt.Text = "metroLabel4";
            // 
            // maasitxt
            // 
            this.maasitxt.AutoSize = true;
            this.maasitxt.Location = new System.Drawing.Point(125, 407);
            this.maasitxt.Name = "maasitxt";
            this.maasitxt.Size = new System.Drawing.Size(83, 19);
            this.maasitxt.TabIndex = 5;
            this.maasitxt.Text = "metroLabel5";
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(114, 453);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(113, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Tamam";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tekPersonelGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 510);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.maasitxt);
            this.Controls.Add(this.gorevitxt);
            this.Controls.Add(this.telefontxt);
            this.Controls.Add(this.tckNotxt);
            this.Controls.Add(this.aditxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "tekPersonelGoruntule";
            this.Text = "UGUR DORM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroLabel aditxt;
        public MetroFramework.Controls.MetroLabel tckNotxt;
        public MetroFramework.Controls.MetroLabel telefontxt;
        public MetroFramework.Controls.MetroLabel gorevitxt;
        public MetroFramework.Controls.MetroLabel maasitxt;
        public MetroFramework.Controls.MetroButton metroButton1;
    }
}