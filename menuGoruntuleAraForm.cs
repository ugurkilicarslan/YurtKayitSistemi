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
    public partial class menuGoruntuleAraForm : MetroFramework.Forms.MetroForm
    {
        veritabanı vt = new veritabanı();

        public menuGoruntuleAraForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            var yemekler = vt.menuler.Where(s => s.tarih == date).FirstOrDefault();
            if (yemekler != null)
            {
                menuGoruntule mg = new menuGoruntule();
                mg.richTextBox1.Text = yemekler.yemekler;
                mg.ShowDialog();
            }

            else
            {
                MessageBox.Show("Kayıt bulunamadı!");
            }
            
        }
    }
}
