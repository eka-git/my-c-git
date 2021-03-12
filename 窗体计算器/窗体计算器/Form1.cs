using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(textBox1.Text);
            float b = Convert.ToSingle(textBox2.Text);
          //  double c=0;
        //    string s = Convert.toString(comboBox1.SelectedIndex);
            switch (comboBox1.SelectedItem)
            {
                case '加':
                    textBox3.Text = Convert.ToString(a + b);
                 //   c = a + b;
                    break;
                case '除':
                    textBox3.Text = Convert.ToString(a / b);
                //    c = a / b;
                    break;
                case '减':
                    textBox3.Text = Convert.ToString(a - b);
                //    c = a - b;
                    break;
                case '乘':
                    textBox3.Text = Convert.ToString(a * b);
              //      c = a * b;
                    break;
            }
         //   textBox3.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        //    double b = Convert.ToDouble(this.textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          //  double a = Convert.ToDouble(this.textBox1.Text);
        }
    }
}
