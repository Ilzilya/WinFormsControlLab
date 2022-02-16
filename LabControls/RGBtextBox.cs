using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LabControls
{
    public partial class RGBtextBox : TextBox
    {
        public RGBtextBox()
        {
            InitializeComponent();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)) && (e.KeyChar < 65 || e.KeyChar > 70))
                e.Handled = true;

            base.OnKeyPress(e);
        }

        public RGBtextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
