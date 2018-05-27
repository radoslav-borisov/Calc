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

        private void button3_Click(object sender, EventArgs e)
        {
            // make sure boxes are empty when importing
            if (moraleBox.Text != null && moraleBox.Text != textBox9.Text) moraleBox.Text = null ;
            if (matkBox.Text != null && matkBox.Text != textBox10.Text) matkBox.Text = null;
            if (mdefBox.Text != null && mdefBox.Text != textBox11.Text) mdefBox.Text = null;
            //chrgBox.Text = null;
            //armourBox.Text = null;
            //wepdBox.Text = null;
            // import values "properly"
            double value = 0;
            Double.TryParse(textBox9.Text,out value);
            moraleBox.Text += Math.Floor(value);
            Double.TryParse(textBox10.Text, out value);
            matkBox.Text += Math.Ceiling(value);
            Double.TryParse(textBox11.Text, out value);
            mdefBox.Text += Math.Ceiling(value);
        }

        private void matkBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(matkBox.Text)) matkBox.Text = string.Empty;
        }

        private void wepdBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(wepdBox.Text)) wepdBox.Text = string.Empty;
        }

        private void chrgBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(chrgBox.Text)) chrgBox.Text = string.Empty;
        }

        private void mdefBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(mdefBox.Text)) mdefBox.Text = string.Empty;
        }

        private void armourBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(armourBox.Text)) armourBox.Text = string.Empty;
        }

        private void moraleBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(moraleBox.Text)) moraleBox.Text = string.Empty;
        }

        private void matkb_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(matkb.Text)) matkb.Text = string.Empty;
        }

        private void wepdb_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(wepdb.Text)) wepdb.Text = string.Empty;
        }

        private void chrgb_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(chrgb.Text)) chrgb.Text = string.Empty;
        }

        private void mdefb_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(mdefb.Text)) mdefb.Text = string.Empty;
        }

        private void armb_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(armb.Text)) armb.Text = string.Empty;
        }

        private void moraleb_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(moraleb.Text)) moraleb.Text = string.Empty;
        }

        private void arms_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(arms.Text)) arms.Text = string.Empty;
        }

        private void mdefs_KeyUp(object sender, KeyEventArgs e)
        {
            if (!checkdigits(mdefs.Text)) mdefs.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 0) make sure double click doesnt double print
            matk_r.Text = null;
            double stat = 0;
            double shield = 0;
            double bonus = 0;
            // 1) take base value 
            Double.TryParse(matkBox.Text, out stat);
            Double.TryParse(matkb.Text, out bonus);
            // 2) do the math based on bonus box
            stat = stat + (stat * bonus / 100);
            matk_r.Text += stat;
            // 0)
            wepd_r.Text = null;
            // 1)
            Double.TryParse(wepdBox.Text, out stat);
            Double.TryParse(wepdb.Text, out bonus);
            // 2)
            stat = stat + (stat * bonus / 100);
            wepd_r.Text += stat;
            // 0)
            chrg_r.Text = null;
            // 1)
            Double.TryParse(chrgBox.Text, out stat);
            Double.TryParse(chrgb.Text, out bonus);
            // 2)
            stat = stat + (stat * bonus / 100);
            chrg_r.Text += stat;
            // 0) special case - mdef
            mdef_r.Text = null;
            // 1) special case - mdef
            Double.TryParse(mdefBox.Text, out stat);
            Double.TryParse(mdefb.Text, out bonus);
            Double.TryParse(mdefs.Text, out shield);
            // 2) special case - mdef
            stat = stat + (stat * bonus / 100);
            shield = shield + (shield * bonus / 100);
            mdef_r.Text += stat + shield;
            // 0) special case - armour
            armour_r.Text = null;
            // 1) special case - armour
            Double.TryParse(armourBox.Text,out stat);
            Double.TryParse(armb.Text, out bonus);
            Double.TryParse(arms.Text, out shield);
            // 2) special case - armour
            stat = stat + (stat * bonus / 100);
            shield = shield + (shield * bonus / 100);
            armour_r.Text += stat + shield;
            // 0)
            morale_r.Text = null;
            // 1)
            Double.TryParse(moraleBox.Text, out stat);
            Double.TryParse(moraleb.Text, out bonus);
            // 2)
            stat = stat + (stat * bonus / 100);
            morale_r.Text += stat;
        }
    }
}
