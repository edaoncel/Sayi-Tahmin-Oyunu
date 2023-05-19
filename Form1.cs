using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayi_tahmini_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        Random rastgele = new Random();
        private object textSayi;
       
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            sayi = rastgele.Next(0, 101);
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            int girilensayi = Convert.ToInt32(txt_tahmin.Text);
            if(sayi == girilensayi)
            {
                lblMesaj.Text = "daha büyük bir sayi girin";
            }
            if (sayi < girilensayi)
            {
                lblMesaj.Text = "daha kücük bir sayi girin";
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
