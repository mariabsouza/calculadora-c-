using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()   
        {
            InitializeComponent();
        }

        int nmr1, nmr2;
        char sinal;
        
        private void button1_Click(object sender, EventArgs e)
        {
            nmr1 = 1;
            textBox1.Text = nmr1.ToString();
        }

        //Botão de soma
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = nmr1.ToString() + " + ";
            sinal = '+';
        }

        //Botão de igual
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = nmr1 + int.Parse(sinal) + nmr2;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (sinal == '+')
            {
                nmr2 = 2;
                textBox1.Text = nmr1.ToString() + sinal + nmr2.ToString();

            } else
            {
                nmr1 = 2;
                textBox1.Text = nmr1.ToString();
            }
        }
    }
}
