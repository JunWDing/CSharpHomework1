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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double res = 0;
            try
            {
                double firstnum = Double.Parse(firstNum.Text);
                double secondnum = Double.Parse(secondNum.Text);
                string opera = operat.Text;
                switch (opera)
                {
                    case "+": res = firstnum + secondnum; break;
                    case "-":res = firstnum - secondnum; break;
                    case "*":res = firstnum * secondnum; break;
                    case "/":res = firstnum / secondnum; break;
                    default:result.Text = "错误"; return;
                }
                result.Text = $"运算结果为{res}";
            }
            catch(Exception x)
            {
                result.Text = "错误";
            }
        }
    }
}
