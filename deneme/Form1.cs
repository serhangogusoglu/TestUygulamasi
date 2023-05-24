using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dogru = 0, yanlıs = 0, basari = 0;

            if (radioButton3.Checked) { dogru = dogru + 1;}
            if (radioButton5.Checked) { dogru = dogru + 1; }
            if (radioButton11.Checked) { dogru = dogru + 1; }
            if (radioButton14.Checked) { dogru = dogru + 1; }
            if (radioButton17.Checked) { dogru = dogru + 1; }

            yanlıs = 5 - dogru;
            basari = dogru * 20;

            textBox1.Text = dogru.ToString();
            textBox2.Text = yanlıs.ToString();
            textBox3.Text = basari.ToString();
        }
    }
}
