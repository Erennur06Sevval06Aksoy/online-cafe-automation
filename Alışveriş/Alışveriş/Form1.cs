using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alışveriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double top1, top2, top3, top4, top5;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (checkBox1.Checked)
            {
                double cay = Convert.ToDouble(textBox1.Text);
                top1 = top1 + (cay * 0.75);
                listBox1.Items.Add(cay+" adet çay: "+top1+"tl.");
            }
            if (checkBox2.Checked)
            {
                double kahve = Convert.ToDouble(textBox2.Text);
                top2 = top2 + (kahve * 1.25);
                listBox1.Items.Add(kahve + " adet kahve: " + top2 + "tl.");
            }
            if (checkBox3.Checked)
            {
                double tost = Convert.ToDouble(textBox3.Text);
                top3 = top3 + (tost * 4);
                listBox1.Items.Add(tost + " adet tost: " + top3 + "tl.");
            }
            if (checkBox4.Checked)
            {
                double su = Convert.ToDouble(textBox4.Text);
                top4 = top4 + (su * 1);
                listBox1.Items.Add(su + " adet su: " + top4 + "tl.");
            }
            if (checkBox5.Checked)
            {
                double cikolata = Convert.ToDouble(textBox5.Text);
                top5 = top5 + (cikolata * 3);
                listBox1.Items.Add(cikolata + " adet çikolata: " + top5 + "tl.");
            }
            double total,yuzde,toplam;
            total = top1 + top2 + top3 + top4 + top5 ;
            if (total>=20)
            {
                yuzde = total / 10;
                toplam = total - yuzde;
                listBox1.Items.Add("Toplam tutarınız " + toplam + " TL dir.");
            }
            else if (total>=50)
            {
                yuzde = total / 5;
                toplam = total - yuzde;
                listBox1.Items.Add("Toplam tutarınız " + toplam + " TL dir.");
            }   
        }
    }
}
