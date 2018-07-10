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
    public partial class baslangic : MetroFramework.Forms.MetroForm
    {
        public baslangic()
        {
            InitializeComponent();
        }

        private void subeArtirbtn_MouseHover(object sender, EventArgs e)
        {
            metroLabel4.Visible = true;
        }

        private void subeArtirbtn_MouseLeave(object sender, EventArgs e)
        {
            metroLabel4.Visible = false;
        }

        private void metroTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox4.Text.Contains("@"))
            {
                
                comboBox1.Visible = true;
                comboBox1.DroppedDown = true;
                

            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            metroTextBox4.Text += comboBox1.SelectedItem.ToString();
            comboBox1.Visible = false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //subeDuzenle sb = new subeDuzenle();
            //sb.ShowDialog();
            //this.Hide();
        }
    }
}
