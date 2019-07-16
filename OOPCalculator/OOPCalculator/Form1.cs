using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateClick(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(textBox1.Text);
            double secondNumber = Convert.ToDouble(textBox2.Text);
            double result;

            switch (((Button)sender).Name)
            {
                case "Add":
                    result = firstNumber + secondNumber; break;
                case "Subtraction":
                    result = firstNumber - secondNumber; break;
                case "Divide":
                    result = firstNumber / secondNumber; break;
                case "Multiply":
                    result = firstNumber * secondNumber; break;
                default: throw new Exception("Неизвестная операция");

            }

            resultLable.Text = Convert.ToString(result);
        }
    }
}
