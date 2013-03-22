using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seller.CONTROLS.Usterki
{
    public partial class UsterkaAddView : Form
    {
        #region PUBLIC

        public enum TYPE
        {
            ADD,
            VIEW
        }

        public bool CANCEL = true;

        public string USTERKA { get { return txtUsterka.Text; } set { txtUsterka.Text = value; } }

        #endregion

        #region PRIVATE

        private TYPE TrybPracy = TYPE.ADD;

        private Number num = new Number();

        #endregion

        public UsterkaAddView(TYPE Tryb)
        {
            InitializeComponent();

            this.TrybPracy = Tryb;
        }

        private void UsterkaAddView_Load(object sender, EventArgs e)
        {
            switch (TrybPracy)
            {
                case TYPE.ADD:
                    this.Text = "Nowy objaw";
                    break;

                case TYPE.VIEW:
                    this.Text = "Podgląd";
                    cmdUstarkaDodaj.Visible = false;
                    cmdAnuluj.Text = "Zamknij";
                    break;
            }
        }

        private void txtUsterka_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumberLetterHash(this, e);
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdUstarkaDodaj_Click(object sender, EventArgs e)
        {
            if (CheckEntry.CheckEntryCtrl(new List<Control> { txtUsterka })) return;

            CANCEL = false;

            Close();
        }
    }
}
