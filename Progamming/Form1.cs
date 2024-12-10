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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("15 + 5 = "+(15+5));
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor= Color.Yellow;
            button1.ForeColor= Color.Red;
            button1.Text = "Calculate";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.Red;
            button1.Text = "ok";
        }
    }
}
