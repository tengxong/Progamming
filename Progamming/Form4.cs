using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progamming
{
    public partial class Form4 : Form
    {
        private string currentExpression = ""; 

        public Form4()
        {
            InitializeComponent();
        }

        private void DigitBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }
            DisplayTextBox.Text += btn.Text;
            currentExpression += btn.Text;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!DisplayTextBox.Text.Contains("."))
            {
                DisplayTextBox.Text += ".";
                currentExpression += ".";
            }
        }

        private void times_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text += " * ";
            currentExpression += " * ";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text += " + ";
            currentExpression += " + ";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text += " - ";
            currentExpression += " - ";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text += " / ";
            currentExpression += " / ";
        }

        private void percent_Click(object sender, EventArgs e)
        {
            try
            {
                // คำนวณเปอร์เซ็นต์โดยแปลงค่าปัจจุบันให้เป็นเปอร์เซ็นต์ใน currentExpression
                decimal currentValue = Convert.ToDecimal(DisplayTextBox.Text);
                decimal percentValue = currentValue / 100;
                DisplayTextBox.Text = percentValue.ToString();
                currentExpression = percentValue.ToString();
            }
            catch
            {
                DisplayTextBox.Text = "Error";
                currentExpression = "";
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(currentExpression, null);
                DisplayTextBox.Text = result.ToString(); 
                currentExpression = result.ToString();    
            }
            catch
            {
                DisplayTextBox.Text = "Error";
                currentExpression = "";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
            currentExpression = ""; 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text.Length > 1)
            {
                DisplayTextBox.Text = DisplayTextBox.Text.Substring(0, DisplayTextBox.Text.Length - 1);
                currentExpression = currentExpression.Substring(0, currentExpression.Length - 1);
            }
            else
            {
                DisplayTextBox.Text = "0";
                currentExpression = "";
            }
        }
    }
}
