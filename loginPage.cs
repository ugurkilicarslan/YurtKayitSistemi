using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Sql;
using System.Data.OleDb;

namespace YurtOtomasyonu
{
    public partial class loginPage : MetroFramework.Forms.MetroForm
    {

        veritabanı vt = new veritabanı();
        
        public loginPage()
        {
            InitializeComponent();
        }
        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var auth = vt.login.Where(s => s.kAdi == metroTextBox1.Text.ToString() && s.sifre == metroTextBox2.Text.ToString()).FirstOrDefault();

            if (auth!=null)
            {
                
                anasayfa an = new anasayfa();
                this.Hide();
                an.ShowDialog();


            }
            else
            {
                MessageBox.Show("Hata");
            }
           

        }

        private void loginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
