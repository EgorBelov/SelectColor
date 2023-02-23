using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabControls
{
    public partial class NumberBox : TextBox
    {
        public bool IsDec { get; set; }
        public bool IsHex { get; set; }
        public NumberBox()
        {
            InitializeComponent();
        }

        public NumberBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void TextIsDec(EventArgs e)
        {
            bool ok;
            int x;
            do
            {
                try
                {
                    x = (Convert.ToInt32(Text));
                    ok = true;
                }
                catch
                {
                    Text = "0";
                    ok = false;
                }
            }
            while (!ok);


            if (Convert.ToInt32(Text) > 255)
                Text = "255";
            if (Convert.ToInt32(Text) < 0)
                Text = "0";
            base.OnTextChanged(e);
        }
        private void TextIsHex(EventArgs e)
        {
            int x;
            bool ok;
            do
            {
                try
                {
                    x = (Convert.ToInt32(Text, 16));
                    ok = true;
                }
                catch
                {
                    Text = "0";
                    ok = false;
                }
            }
            while (!ok);

            if (Convert.ToInt32(Text, 16) > 255)
                Text = "FF";
            if (Convert.ToInt32(Text, 16) < 0)
                Text = "0";
            base.OnTextChanged(e);
        }


        private void KeyPressIsDec(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }
        private void KeyPressIsHex(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) 
                && (e.KeyChar < 'A' || e.KeyChar > 'F') && (e.KeyChar < 'a' || e.KeyChar > 'f'))
                e.Handled = true;
            base.OnKeyPress(e);
        }


        protected override void OnTextChanged(EventArgs e)
        {
            if (IsDec)
                TextIsDec(e);
            if (IsHex)
                TextIsHex(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (IsDec)
                KeyPressIsDec(e);
            if (IsHex)
                KeyPressIsHex(e);
        }
    }
}
