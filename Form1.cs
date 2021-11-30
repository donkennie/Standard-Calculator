using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardCalculator
{
    public partial class eight : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public eight()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if((result.Text == "0") || (operation_pressed)) 
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            if(b.Text== ".")
            {
                if(!result.Text.Contains("."))
                    result.Text += b.Text;
            }
            result.Text += b.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(value != 0)
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + "" + operation;
            }
            else
            {
                operation = b.Text;
                value = double.Parse(result.Text);
                operation_pressed = true;
                equation.Text = value + "" + operation;
            }

           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = double.Parse(result.Text);
            operation = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eig.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    mult.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                case "ENTER":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
