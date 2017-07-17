using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayılar = { 4, 5 };
                int toplam = 0;

                foreach (int sayı in sayılar)//int sayının değerini sayılar adlı dizinin içinden çek in=içinden
                {
                    toplam = toplam + sayı;   // + yeine başka bir matematik(+-/*) oparatörü koyabilirsiniz örnegin * koyarsanız dizinin bütün degerlerini çarpar.
                    label1.Text = toplam.ToString();
                }
        }
    }
}
