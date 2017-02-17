using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator02
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
            Calculate(1);
        }
        private void Calculate(int i)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            switch(i)
            { 
                case 1:
                label1.Text = (x + y).ToString();
                break;
                case 2:
                label1.Text = (x - y).ToString();
                break;
                case 3:
                label1.Text = (x * y).ToString();
                break;
                case 4:
                label1.Text = (x / y).ToString();
                break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculate(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculate(4);
        }
    }
}
