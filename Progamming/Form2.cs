﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
        InitializeComponent();
        }
        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                txtResult.Text = (num1 + num2).ToString();
            }
             catch (Exception ex) 
            { 
                txtResult.Text = ex.Message;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                txtResult.Text = (num1 - num2).ToString();
            }
            catch (Exception ex)
            { 
              txtResult.AcceptsReturn = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            txtResult.Text = (num1 * num2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            txtResult.Text = (num1 / num2).ToString();
        }
    }
}
