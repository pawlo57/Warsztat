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
    public partial class newCategory : Form
    {
        private Number num = new Number();

        public bool CANCEL = true;

        public newCategory(string title, string cmdName)
        {
            InitializeComponent();

            this.Text = title;
            cmdOK.Text = cmdName;
        }

        private void txtKategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumberLetter(this, e);
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            CANCEL = false;
            Close();
        }

        public string CATEGORY { get { return txtKategoria.Text; } set { txtKategoria.Text = value; } }
    }
}
