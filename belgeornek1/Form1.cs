using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace belgeornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
        }

        private void btnKonturolEt_Click(object sender, EventArgs e)
        {
            float ortalama;
            ortalama = Convert.ToSingle(txtOrtalama.Text);

            if (ortalama < 0)
            {
                lblSonuc.Text = "Negatif Değer Giremezsin.";
            }
            else if (ortalama < 50)
            {
                lblSonuc.Text = "Kaldızın.";
            }
            else if (ortalama < 70)
            {
                lblSonuc.Text = "Tebrikler. Geçtiniz.";
            }
            else if (ortalama < 85)
            {
                lblSonuc.Text = "Teşekkür Belgesi aldınızz";
            }
            else if (ortalama <= 100)
            {
                lblSonuc.Text = "Taktir aldınızz";
            }
           
        }
    }
}
