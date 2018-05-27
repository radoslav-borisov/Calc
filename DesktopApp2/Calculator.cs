using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DesktopApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // checks if input is valid aka numbers only
        bool checkdigits(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
        // makes sure incorrect input is scrapped
        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(textBox5.Text)) textBox5.Text = string.Empty;
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(textBox6.Text)) textBox6.Text = string.Empty;
        }

        private void textBox7_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(textBox7.Text)) textBox7.Text = string.Empty;
        }

        private void textBox8_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(textBox8.Text)) textBox8.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Prevents writing in textbox twice on double click
            textBox9.Text = null;
            textBox10.Text = null;
            textBox11.Text = null;
            // making some records for stuff we will use to do math
            double morale_growth = 0.1;
            double morale_scalar = 1.25;
            double mad_growth = 0.3;
            double mad_scalar = 0.65;
            int exp_level = 0;
            double base_value = 0;
            // 1)taking whatever is in the textboxes and converting it to numbers
            Int32.TryParse(textBox8.Text, out exp_level);
            Double.TryParse(textBox5.Text,out base_value);
            double chev_bonus = 0;
            // 2) doing some math to find what the bonus is 
            chev_bonus = Math.Pow(base_value, morale_growth) * morale_scalar * exp_level;
            base_value += chev_bonus;
            // 3) outputting the new base value for morale, in a 0.00 format
            textBox9.Text += string.Format("{0:F2}", base_value);
            // 1)
            Double.TryParse(textBox6.Text, out base_value);
            // 2)
            chev_bonus = Math.Pow(base_value, mad_growth) * mad_scalar * exp_level;
            base_value += chev_bonus;
            // 3)
            textBox10.Text += string.Format("{0:F2}", base_value);
            // 1)
            Double.TryParse(textBox7.Text, out base_value);
            // 2)
            chev_bonus = Math.Pow(base_value, mad_growth) * mad_scalar * exp_level;
            base_value += chev_bonus;
            // 3)
            textBox11.Text += string.Format("{0:F2}", base_value);
        }
    }
}
