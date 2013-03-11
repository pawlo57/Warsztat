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
    public partial class FindWorker : Form
    {
        #region PUBLIC

        public bool CANCEL = true;

        public string KONTO_BANKOWE { get { return txtNumerKonta.Text; } set { txtNumerKonta.Text = value; } }

        #endregion

        private Number num = new Number();

        List<TextBox> cmdList = new List<TextBox>();

        public FindWorker(string title, string cmdName)
        {
            InitializeComponent();

            this.Text = title;
            cmdNowy.Text = cmdName;
        }

        private bool CheckEntry()
        {
            ClearTextBoxes();

            if (String.IsNullOrEmpty(IMIE)) MarkTextBox(txtImie);
            if (String.IsNullOrEmpty(NAZWISKO)) MarkTextBox(txtNazwisko);
            if (String.IsNullOrEmpty(ADRES)) MarkTextBox(txtAdres);
            if (String.IsNullOrEmpty(PESEL)) MarkTextBox(txtPesel);

            if (cmdList.Count > 0) 
            { Message.ErrorMessage("Proszę uzupełnić wymagane pola (zaznaczone na żółto)"); return false; }

            return true;
        }

        private void MarkTextBox(TextBox button)
        {
            button.BackColor = Color.Yellow;
            button.Focus();

            cmdList.Add(button);
        }

        private void ClearTextBoxes()
        {
            for (int i = 0; i < cmdList.Count; i++)
            {
                TextBox txt = cmdList[i];

                txt.BackColor = Color.White;
            }

            cmdList.Clear();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtImie_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckLetter(this, e);
        }

        private void txtAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumberLetterHash(this, e);
        }

        private void txtPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumber(this, e);
        }

        private void txtNIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumberLetter(this, e);
        }

        public string IMIE { get { return txtImie.Text; } set { txtImie.Text = value; } }

        public string NAZWISKO { get { return txtNazwisko.Text; } set { txtNazwisko.Text = value; } }

        public string ADRES { get { return txtAdres.Text; } set { txtAdres.Text = value; } }

        public string PESEL { get { return txtPesel.Text; } set { txtPesel.Text = value; } }

        public string NIP { get { return txtNIP.Text; } set { txtNIP.Text = value; } }

        public string BANK { get { return txtNumerKonta.Text; } set { txtNumerKonta.Text = value; } }

        private void cmdNowy_Click(object sender, EventArgs e)
        {
            if (cmdNowy.Text != "Szukaj")
                if (!CheckEntry()) return;

            CANCEL = false;

            Close();
        }

        private void FindWorker_Load(object sender, EventArgs e)
        {

        }

      

    }
}
