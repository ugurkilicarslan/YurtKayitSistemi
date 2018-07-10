using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    public partial class giderler : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();
        public giderler()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            float tutar = float.Parse(metroTextBox1.Text);
            gider gdr = new gider();
            gdr.giderTuru = comboBox1.SelectedItem.ToString();
            gdr.tutar = tutar;

            vt.gider.Add(gdr);
            vt.SaveChanges();

            MessageBox.Show("Gider Eklendi");

            this.Close();
        }
    }
}
