using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = 1;
            int n2 = 1;
            listBox1.Items.Add(n1.ToString());
            listBox1.Items.Add(n2.ToString());
            for (int contador = 3; contador <= Convert.ToInt32(textBox1.Text); contador++)
            {
                int total = n1 + n2;
                n1 = n2;
                n2 = total;
                listBox1.Items.Add(total.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
