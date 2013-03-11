using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seller
{
    public partial class Login : Form
    {
        public bool CANCEL = true;

        private Number num;

        public Login()
        {
            InitializeComponent();

            num = new Number();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdZaloguj_Click(object sender, EventArgs e)
        {
            CANCEL = false;
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumberLetter(this, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumberLetter(this, e);
        }

        public string USER { get { return textBox1.Text; } }

        public string PASSWORD { get { return textBox2.Text; } }
    }
}
