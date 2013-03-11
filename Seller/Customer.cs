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
    public partial class Customer : Form
    {
        #region PUBLIC

        public enum TYPE
        {
            NEW,
            EDIT,
            VIEW,
            FIND
        }

        public bool CANCEL = true;

        #endregion

        #region PRIVATE

        private TYPE TrybPracy = TYPE.NEW;

        private Number num = new Number();

        private List<TextBox> cmdList = new List<TextBox>();

        #endregion

        public Customer(TYPE typ)
        {
            InitializeComponent();

            TrybPracy = typ;
        }

        private bool CheckEntry()
        {
            ClearTextBoxes();

            if (String.IsNullOrEmpty(FIRMA) &&
             String.IsNullOrEmpty(IMIE) &&
             String.IsNullOrEmpty(NAZWISKO) &&
             String.IsNullOrEmpty(ADRES) &&
             String.IsNullOrEmpty(NIP) &&
             String.IsNullOrEmpty(TELEFON)) return false;
           
            //if (cmdList.Count > 0)
            //{ Message.ErrorMessage("Proszę uzupełnić wymagane pola (zaznaczone na żółto)"); return false; }

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

        private void cmdNowy_Click(object sender, EventArgs e)
        {
            if (TrybPracy != TYPE.FIND)
            {
                if (!CheckEntry())
                {
                    Message.ErrorMessage("Nie uzupełniono żadnej pozycji");
                    return;
                }
            }
            else
            {
                txt_Click(txtFirma, e);
                txt_Click(txtImie, e);
                txt_Click(txtNazwisko, e);
                txt_Click(txtAdres, e);
                txt_Click(txtNIP, e);
                txt_Click(txtPesel, e);
                txt_Click(txtBank, e);
                txt_Click(txtTelefon, e);
            }

            CANCEL = false;
            Close();
        }

        private void txtFirma_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckNumberLetter(this, e);
        }

        private void txtImie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckLetter(this, e);
        }

        private void txtNazwisko_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckLetter(this, e);
        }

        private void txtAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckNumberLetterHash(this, e);
        }

        #region ACCESS

        public string FIRMA { get { return txtFirma.Text; } set { txtFirma.Text = value; } }

        public string IMIE { get { return txtImie.Text; } set { txtImie.Text = value; } }

        public string NAZWISKO { get { return txtNazwisko.Text; } set { txtNazwisko.Text = value; } }

        public string ADRES { get { return txtAdres.Text; } set { txtAdres.Text = value; } }

        public string NIP { get { return txtNIP.Text; } set { txtNIP.Text = value; } }

        public string PESEL { get { return txtPesel.Text; } set { txtPesel.Text = value; } }

        public string BANK { get { return txtBank.Text; } set { txtBank.Text = value; } }

        public string TELEFON { get { return txtTelefon.Text; } set { txtTelefon.Text = value; } }

        #endregion

        private void txtNIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy == TYPE.VIEW) e.Handled = true;
            else num.CheckNumber(this, e);
        }

        private void LoadNew()
        {
            this.Text = "Nowy klient/kontrahent";
            cmdNowy.Text = "Wprowadź";
        }

        private void LoadEdit()
        {
            this.Text = "Klient/kontrahent - edycja";
            cmdNowy.Text = "Zapisz";
        }

        private void LoadView()
        {
            this.Text = "Klient/kontrahent - podgląd";
            cmdNowy.Visible = false;
            cmdNowy.Enabled = false;

            cmdCancel.Text = "Zamknij";
        }

        private void LoadFind()
        {
            this.Text = "Klient/kontrahent - wyszukiwanie";
            cmdNowy.Text = "Szukaj";

            txtFirma.Text =
                txtImie.Text =
                txtNazwisko.Text =
                txtAdres.Text =
                txtNIP.Text =
                txtPesel.Text =
                txtBank.Text = 
                txtTelefon.Text = "Wszystkie";
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            switch (TrybPracy)
            {
                case TYPE.NEW:
                    LoadNew();
                    break;

                case TYPE.EDIT:
                    LoadEdit();
                    break;

                case TYPE.VIEW:
                    LoadView();
                    break;

                case TYPE.FIND:
                    LoadFind();
                    break;
            }

        }

        private void txt_Click(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;

            if (txtBox.Text == "Wszystkie") txtBox.Clear();
        }

        

        

       
    }
}
