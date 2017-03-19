using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.AppendText("2");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBox.AppendText("/");
        }

        private void buttonOnePerX_Click(object sender, EventArgs e)
        {
            var prev = textBox.Text;
            textBox.Text = "";
            textBox.AppendText("1/(" + prev + ")");
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
            textBox.Text = "";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "") {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.AppendText("9");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBox.AppendText("*");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.AppendText("6");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBox.AppendText("-");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.AppendText("3");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox.AppendText("+");
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            var prev = textBox.Text;
            textBox.Text = "-(" + prev + ")";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.AppendText("0");
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBox.AppendText(".");
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {                     
            try
            {
                textResult.Text = (new DataTable().Compute(textBox.Text, null)).ToString();
            }
            catch (System.Data.SyntaxErrorException ex)
            {
                textResult.Text = "Syntax error (;__;)<";
            }
            finally {
                textBox.Text = "";
            }
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            textBox.AppendText("%");
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            textBox.AppendText("(");
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            textBox.AppendText(")");
        }
    }
}
