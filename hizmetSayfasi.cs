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
    public partial class hizmetSayfasi : MetroFramework.Forms.MetroForm
    {
        public hizmetSayfasi()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            menuolustur mo = new menuolustur();
            mo.ShowDialog();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            menuGoruntuleAraForm ma = new menuGoruntuleAraForm();
            ma.ShowDialog();
        }
    }
}
