using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios_prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float[] numeros = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text) };
            listBox1.Items.Add(numeros[0].ToString());
            listBox1.Items.Add(numeros[1].ToString());
            listBox1.Items.Add(numeros[2].ToString());
            listBox1.Items.Add(numeros[3].ToString());
            listBox1.Items.Add(numeros[4].ToString());
            listBox1.Items.Add(numeros[5].ToString());
            listBox1.Items.Add(numeros[6].ToString());
            listBox1.Items.Add(numeros[7].ToString());
            listBox1.Items.Add(numeros[8].ToString());
            listBox1.Items.Add(numeros[9].ToString());
        }
    }
}
