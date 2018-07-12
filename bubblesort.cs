using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            float x;
            float[] numeros = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text) };
            for (i = 0; i <= 5; i++)
            {
                for (j = i + 1; j <= 4; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        x = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = x;
                    }
                }
            }
            listBox1.Items.Add(numeros[0].ToString());
            listBox1.Items.Add(numeros[1].ToString());
            listBox1.Items.Add(numeros[2].ToString());
            listBox1.Items.Add(numeros[3].ToString());
            listBox1.Items.Add(numeros[4].ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
