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
using OOPCalculator.OneArgumentsFunction;

namespace OOPCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TwoArgumentClick(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(textBox1.Text);
            double secondNumber = Convert.ToDouble(textBox2.Text);

            var calculator = TwoArgumentFactory.CreateCalculator(((Button)sender).Name);
            var result = calculator.Calculator(firstNumber, secondNumber);
            resultLable.Text = Convert.ToString(result);
        }

        private void OneArgumentClick(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(textBox1.Text);

            var calculator = OneArgumentFactory.CreateCalc(((Button)sender).Name);
            var result = calculator.Calculate(firstNumber);
            resultLable.Text = Convert.ToString(result);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
