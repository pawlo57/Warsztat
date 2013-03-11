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
    public partial class Magazyny : Form
    {
        Number number = new Number();

        public bool CANCEL = true;

        public string MAGAZYN { get { return txtMagazyn.Text; } set { txtMagazyn.Text = value; } }

        public string ADRES { get { return txtAdres.Text; } set { txtAdres.Text = value; } }

        public Magazyny()
        {
            InitializeComponent();
        }

        private void cmdKoniec_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void Magazyny_Load(object sender, EventArgs e)
        {
            //LoadMagazyny();
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            if (CheckEntry.CheckEntryCtrl(new List<Control> { txtMagazyn, txtAdres })) return;

            CANCEL = false;
            Close();
        }


       

        private void cbxMagazyny_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       

        private void txtMagazyn_KeyPress(object sender, KeyPressEventArgs e)
        {
            number.CheckNumberLetterHash(this, e);
        }

        

        
    }
}
