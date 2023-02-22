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
    public partial class RGBController : UserControl
    {
        private bool IsDone = true;
        public RGBController()
        {
            InitializeComponent();
            ChangeColor();
            radioButtonDec.Checked = true;
        }

        public void ChangeDigit()
        {
            txtRed.Text = Convert.ToInt32(txtRed.Text, 16).ToString();
            txtBlue.Text = Convert.ToInt32(txtBlue.Text, 16).ToString();
            txtGreen.Text = Convert.ToInt32(txtGreen.Text, 16).ToString();
        }

        public void ChangeColor()
        {
            if (radioButtonDec.Checked)
                colorBox.BackColor = Color.FromArgb(Convert.ToInt32(txtRed.Text), Convert.ToInt32(txtGreen.Text), Convert.ToInt32(txtBlue.Text));
            if (radioButtonHex.Checked)
                colorBox.BackColor = Color.FromArgb(Convert.ToInt32(txtRed.Text, 16), Convert.ToInt32(txtGreen.Text, 16), Convert.ToInt32(txtBlue.Text, 16));
        }

        private void TextChanged(object sender, EventArgs e)
        {
            if (IsDone)
                ChangeColor();          
        }

        private void radioButtonDec_CheckedChanged(object sender, EventArgs e)
        {
            IsDone = false;
            if (radioButtonDec.Checked)
            {
                txtRed.IsDec = true;
                txtGreen.IsDec = true;
                txtBlue.IsDec = true;               

                txtRed.IsHex = false;
                txtGreen.IsHex = false;
                txtBlue.IsHex = false;

                txtRed.Text = Convert.ToInt32(txtRed.Text, 16).ToString();
                txtGreen.Text = Convert.ToInt32(txtGreen.Text, 16).ToString();
                txtBlue.Text = Convert.ToInt32(txtBlue.Text, 16).ToString();               
            }
            else
            {
                txtRed.IsHex = true;
                txtGreen.IsHex = true;
                txtBlue.IsHex = true;               

                txtRed.IsDec = false;
                txtGreen.IsDec = false;
                txtBlue.IsDec = false;

                txtRed.Text = Convert.ToInt32(txtRed.Text, 10).ToString("X");
                txtGreen.Text = Convert.ToInt32(txtGreen.Text, 10).ToString("X");
                txtBlue.Text = Convert.ToInt32(txtBlue.Text, 10).ToString("X");                               
            }
            IsDone = true;
        }
    }
}
