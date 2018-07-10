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
    public partial class menuolustur : MetroFramework.Forms.MetroForm

    {
        veritabanı vt = new veritabanı();
        public menuolustur()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            menuler me = new menuler();
            me.yemekler = richTextBox1.Text;
            me.tarih = dateTimePicker1.Value;

            vt.menuler.Add(me);
            vt.SaveChanges();
            MessageBox.Show("Yemekler basariyla eklendi !");
            this.Close();
        }
    }
}
