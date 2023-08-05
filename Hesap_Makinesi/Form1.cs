using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toplama.BackColor = SystemColors.Control;
            cikarma.BackColor = SystemColors.Control;
            bolme.BackColor = SystemColors.Control;
            carpma.BackColor = SystemColors.Control;
        }

        string sayi1 , sayi2 ;

        // sayılarımızın değerlerini ve toplam değerini oluşturduk

        int tplm = 0, ckrm = 0, crpm = 0, blm = 0 , toplam;

        // butonlara basınca harekete geçirme işlemini burdan yapacağız

        private void button1_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0)
            {
                sayi1 = sayi1 + "1";
                label1.Text = sayi1;
                textBox1.Text = label1.Text;
            }

            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1)
            {
                sayi2 = sayi2 + "1";
                label2.Text = sayi2;
                textBox1.Text = label2.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0)
            {
                sayi1 = sayi1 + "2";
                label1.Text = sayi1;
                textBox1.Text = label1.Text;
            }

            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1)
            {
                sayi2 = sayi2 + "2";
                label2.Text = sayi2;
                textBox1.Text = label2.Text;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0)
            {
                sayi1 = sayi1 + "3";
                label1.Text = sayi1;
                textBox1.Text = label1.Text;
            }

            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1)
            {
                sayi2 = sayi2 + "3";
                label2.Text = sayi2;
                textBox1.Text = label2.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0)
            {
                sayi1 = sayi1 + "4";
                label1.Text = sayi1;
                textBox1.Text = label1.Text;
            }

            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1)
            {
                sayi2 = sayi2 + "4";
                label2.Text = sayi2;
                textBox1.Text = label2.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0)
            {
                sayi1 = sayi1 + "5";
                label1.Text = sayi1;
                textBox1.Text = label1.Text;
            }

            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1)
            {
                sayi2 = sayi2 + "5";
                label2.Text = sayi2;
                textBox1.Text = label2.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0)
            {
                sayi1 = sayi1 + "6";
                label1.Text = sayi1;
                textBox1.Text = label1.Text;
            }

            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1)
            {
                sayi2 = sayi2 + "6";
                label2.Text = sayi2;
                textBox1.Text = label2.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0)
            {
                sayi1 = sayi1 + "7";
                label1.Text = sayi1;
                textBox1.Text = label1.Text;
            }

            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1)
            {
                sayi2 = sayi2 + "7";
                label2.Text = sayi2;
                textBox1.Text = label2.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0)
            {
                sayi1 = sayi1 + "8";
                label1.Text = sayi1;
                textBox1.Text = label1.Text;
            }

            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1)
            {
                sayi2 = sayi2 + "8";
                label2.Text = sayi2;
                textBox1.Text = label2.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0)
            {
                sayi1 = sayi1 + "9";
                label1.Text = sayi1;
                textBox1.Text = label1.Text;
            }

            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1)
            {
                sayi2 = sayi2 + "9";
                label2.Text = sayi2;
                textBox1.Text = label2.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tplm == 0 && ckrm == 0 && crpm == 0 && blm == 0)
            {
                sayi1 = sayi1 + "0";
                label1.Text = sayi1;
                textBox1.Text = label1.Text;
            }

            if (tplm == 1 || ckrm == 1 || crpm == 1 || blm == 1)
            {
                sayi2 = sayi2 + "0";
                label2.Text = sayi2;
                textBox1.Text = label2.Text;
            }
        }


        private void toplama_Click(object sender, EventArgs e)
        {
            tplm = 1;
            ckrm = 0;
            crpm = 0;
            blm = 0;
            toplama.BackColor= SystemColors.InactiveCaption;
            cikarma.BackColor= SystemColors.Control;
            bolme.BackColor= SystemColors.Control;
            carpma.BackColor= SystemColors.Control;
            
        }

        private void cikarma_Click(object sender, EventArgs e)
        {
            ckrm = 1;
            tplm = 0;
            crpm =0;
            blm = 0;
            toplama.BackColor = SystemColors.Control;
            cikarma.BackColor = SystemColors.InactiveCaption;
            bolme.BackColor = SystemColors.Control;
            carpma.BackColor = SystemColors.Control;

        }

        private void carpma_Click(object sender, EventArgs e)
        {
            crpm = 1;
            tplm = 0;
            ckrm = 0;
            blm = 0;
            toplama.BackColor = SystemColors.Control;
            cikarma.BackColor = SystemColors.Control;
            bolme.BackColor = SystemColors.Control;
            carpma.BackColor = SystemColors.InactiveCaption;

        }

        private void bolme_Click(object sender, EventArgs e)
        {
            blm = 1;
            tplm = 0;
            crpm = 0;
            ckrm = 0;
            toplama.BackColor = SystemColors.Control;
            cikarma.BackColor = SystemColors.Control;
            bolme.BackColor = SystemColors.InactiveCaption;
            carpma.BackColor = SystemColors.Control;

        }

        private void temizle_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            textBox1.Text = "";
            sayi1 = "";
            sayi2 = "";
            toplam = 0;
            tplm = 0;
            ckrm = 0;
            crpm = 0;
            blm = 0;
            toplama.Enabled = true;
            cikarma.Enabled = true;
            carpma.Enabled = true;
            bolme.Enabled = true;
            label3.Text = "Sonucunuz = ";
            toplama.BackColor = SystemColors.Control;
            cikarma.BackColor = SystemColors.Control;
            bolme.BackColor = SystemColors.Control;
            carpma.BackColor = SystemColors.Control;
        }
        private void sonuc_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt64(sayi1) > 0 && Convert.ToInt64(sayi2) > 0)
            {
                if (tplm == 1)
                {
                    toplam = (int)(Convert.ToInt64(sayi1) + Convert.ToInt64(sayi2));
                    label3.Text = "Sonucunuz = " + toplam;
                    textBox1.Text =Convert.ToString(toplam);
                }
                if (ckrm == 1)
                {
                    toplam = (int)(Convert.ToInt64(sayi1) - Convert.ToInt64(sayi2));
                    label3.Text = "Sonucunuz = " + toplam;
                    textBox1.Text = Convert.ToString(toplam);
                }
                if (crpm == 1)
                {
                    toplam = (int)(Convert.ToInt64(sayi1) * Convert.ToInt64(sayi2));
                    label3.Text = "Sonucunuz = " + toplam;
                    textBox1.Text = Convert.ToString(toplam);
                }
                if (blm == 1)
                {
                    toplam = (int)(Double)(Convert.ToDouble(sayi1) / Convert.ToDouble(sayi2));
                    label3.Text = "Sonucunuz = " + toplam;
                    textBox1.Text = Convert.ToString(toplam);
                }
            }
        }
    }
}
