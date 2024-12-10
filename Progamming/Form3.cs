using System;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Progamming
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Add date format options to the ComboBox
            comboBox.Items.Add("d MMMM yyyy");
            comboBox.Items.Add("d MM yyyy");
            comboBox.Items.Add("MMMM dd, yyyy");
            comboBox.Items.Add("dd-MM-yy");
            comboBox.Items.Add("dd/MM/yyyy");
            comboBox.Items.Add("dddd, MMMM dd");
            comboBox.Items.Add("hh.mm.ss");
            comboBox.Items.Add("hh.mm");
            comboBox.SelectedIndex = 0;

            // Initialize other controls
            this.Controls.Add(comboBox);
            this.Controls.Add(groupBox1);
            this.Controls.Add(Display1);  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTimeFormatInfo dtInfo;
            string DateStyle = comboBox.Text; 

            // Check which radio button is checked
            if (radioButton2.Checked) 
            {
                CultureInfo laoCulture = new CultureInfo("lo-LA");
                dtInfo = laoCulture.DateTimeFormat;
            }
            else if (radioButton1.Checked) 
            {
                dtInfo = DateTimeFormatInfo.InvariantInfo;
            }
            else
            {
                dtInfo = DateTimeFormatInfo.CurrentInfo; 
            }

            // Format and display the date
            Display1.Text = dt.ToString(DateStyle, dtInfo);
        }
    }
}