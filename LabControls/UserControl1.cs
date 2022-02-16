using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void HexBut_CheckedChanged(object sender, EventArgs e)
        {
            if (HexBut.Checked == true)
            {
                int i = Convert.ToInt32(rgBtextBox1.Text);
                rgBtextBox1.Text= String.Format("{0:X}", i);
                i = Convert.ToInt32(rgBtextBox2.Text);
                rgBtextBox2.Text = String.Format("{0:X}", i);
                i = Convert.ToInt32(rgBtextBox3.Text);
                rgBtextBox3.Text = String.Format("{0:X}", i);
            }
        }
        private void DecBut_CheckedChanged(object sender, EventArgs e)
        {
            if (DecBut.Checked == true)
            {
                rgBtextBox1.Text = Convert.ToString(Convert.ToInt32(rgBtextBox1.Text, 16));
                rgBtextBox2.Text = Convert.ToString(Convert.ToInt32(rgBtextBox2.Text, 16));
                rgBtextBox3.Text = Convert.ToString(Convert.ToInt32(rgBtextBox3.Text, 16));
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void rgBtextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void rgBtextBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void rgBtextBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void rgBtextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DecBut.Checked == true)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                    e.Handled = true;
            }
        }

        private void rgBtextBox1_Leave(object sender, EventArgs e)
        {
            if (rgBtextBox1.Text == "") rgBtextBox1.Text = "0";
            if (DecBut.Checked == true)
            {
                if (Convert.ToInt32(rgBtextBox1.Text) > 255)
                {
                    rgBtextBox1.Text = "255";
                }
                colorBox.BackColor = Color.FromArgb(Convert.ToInt32(rgBtextBox1.Text), Convert.ToInt32(rgBtextBox2.Text), Convert.ToInt32(rgBtextBox3.Text));
            }
            if (HexBut.Checked == true)
            {
                if (Convert.ToInt32(rgBtextBox1.Text,16) > 255)
                {
                    rgBtextBox1.Text = "FF";
                }
                colorBox.BackColor = Color.FromArgb(Convert.ToInt32(rgBtextBox1.Text,16), Convert.ToInt32(rgBtextBox2.Text,16), Convert.ToInt32(rgBtextBox3.Text,16));

            }
        }

        private void rgBtextBox2_Leave(object sender, EventArgs e)
        {
            if (rgBtextBox2.Text == "") rgBtextBox2.Text = "0";
            if (DecBut.Checked == true)
            {
                
                if (Convert.ToInt32(rgBtextBox2.Text) > 255)
                {
                    rgBtextBox2.Text = "255";
                }
                colorBox.BackColor = Color.FromArgb(Convert.ToInt32(rgBtextBox1.Text), Convert.ToInt32(rgBtextBox2.Text), Convert.ToInt32(rgBtextBox3.Text));
            }
            if (HexBut.Checked == true)
            {
                if (Convert.ToInt32(rgBtextBox2.Text, 16) > 255)
                {
                    rgBtextBox2.Text = "FF";
                }
                colorBox.BackColor = Color.FromArgb(Convert.ToInt32(rgBtextBox1.Text, 16), Convert.ToInt32(rgBtextBox2.Text, 16), Convert.ToInt32(rgBtextBox3.Text, 16));

            }
        }
        private void rgBtextBox3_Leave(object sender, EventArgs e)
        {
            if (rgBtextBox3.Text == "") rgBtextBox3.Text = "0";
            if (DecBut.Checked == true)
            {
                if (Convert.ToInt32(rgBtextBox3.Text) > 255)
                {
                    rgBtextBox3.Text = "255";
                }
                colorBox.BackColor = Color.FromArgb(Convert.ToInt32(rgBtextBox1.Text), Convert.ToInt32(rgBtextBox2.Text), Convert.ToInt32(rgBtextBox3.Text));
            }
            if (HexBut.Checked == true)
            {
                if (Convert.ToInt32(rgBtextBox3.Text, 16) > 255)
                {
                    rgBtextBox3.Text = "FF";
                }
                colorBox.BackColor = Color.FromArgb(Convert.ToInt32(rgBtextBox1.Text, 16), Convert.ToInt32(rgBtextBox2.Text, 16), Convert.ToInt32(rgBtextBox3.Text, 16));

            }
        }

        private void rgBtextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DecBut.Checked == true)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                    e.Handled = true;
            }
        }

        private void rgBtextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DecBut.Checked == true)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                    e.Handled = true;
            }
        }
    }
}
