using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Seller
{
    public partial class Activate : Form
    {
        private Number num;

        private Aktywacja aktywacja = new Aktywacja();

        public bool CANCEL = true;

        public Activate()
        {
            InitializeComponent();

            num = new Number();

            radioButton2.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtKod.Enabled = true;

                lblInfo.Text = "Zadzwoń pod numer zawarty na umowie licencyjnej aby uzyskać kod aktywacyjny";

                label2.ForeColor = Color.Black;

                cmdAktywuj.Text = "AKTYWUJ";

                txtKod.Focus();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtKod.Enabled = false;

                lblInfo.Text = "Kliknij przycisk DALEJ aby dokonać aktywacji przez Internet";

                cmdAktywuj.Text = "Dalej";

                label2.ForeColor = Color.Gray;
            }
        }

        private void txtKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumberLetter(this, e);
        }

       

        private void cmdAktywuj_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (String.Equals(aktywacja.KOD, txtKod.Text, StringComparison.Ordinal))
                { aktywacja.WriteRegisty(); Message.InfoMessage("Program został aktywowany pomyślnie"); CANCEL = false; Close(); }

                else Message.ErrorMessage("Podano nieprawidłowy kod aktywacyjny!");
            }
            else
            {
                //SellServiceData.SellServiceClient client = new SellServiceData.SellServiceClient();

                //bool result = false;

                //NetData data = new NetData();

                //data.ShowDialog();

                //if (data.CANCEL) return;

                //try
                //{
                //    result = client.Activate(1, data.NUMER, data.FIRMA, data.IMIE, data.NAZWISKO);
                //}
                //catch { Message.ErrorMessage("Błąd połączenia"); return; }

                //if (result) 
                //{ WriteRegisty(); Message.InfoMessage("Program został aktywowany pomyślnie"); CANCEL = false; Close(); }

                //else Message.ErrorMessage("Błąd aktywacji!");
            }
        }
    }
}
