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
    public partial class Uzytkownik : Form
    {
        #region PRIAVTE

        private TYPE TrybPracy = TYPE.NEW;

        private Number num = new Number();

        #endregion

        #region PUBLIC

        public bool CANCEL = true;

        public bool ADMIN = false;

        public enum TYPE
        {
            NEW,
            EDIT,
            VIEW
        }

        public bool STATUS { get { if (comboBox1.SelectedIndex == 0) return true; else return false; } }

        public Users UZYTKOWNIK
        {
            set
            {
                txtLogin.Text = value.LOGIN;
                txtImie.Text = value.IMIE;
                txtNazwisko.Text = value.NAZWISKO;

                PRIV = value.PRIV;

            }

            get
            {
                Users user = new Users();

                user.IMIE = txtImie.Text;
                user.NAZWISKO = txtNazwisko.Text;
                user.LOGIN = txtLogin.Text;

                user.password = txtHaslo.Text;
                user.Repeatpassword = txtPowtorzHaslo.Text;

                user.PRIV = PRIV;

                return user;
            }
        }

        public int PRIV
        {
            get
            {
                int Response = 0;

                for (int i = 0; i < lstPriv.CheckedItems.Count; i++)
                {
                    string item = lstPriv.CheckedItems[i].ToString();

                    if (item == "Produkty") Response |= (1 << (int)USER.PRIV.PRODUKTY);
                    if (item == "Magazyn") Response |= (1 << (int)USER.PRIV.MAGAZYN);
                    if (item == "Usługi") Response |= (1 << (int)USER.PRIV.USŁUGI);
                    if (item == "Kontrahenci") Response |= (1 << (int)USER.PRIV.KONTRAHENCI);
                    if (item == "Pracownicy") Response |= (1 << (int)USER.PRIV.PRACOWNICY);
                    if (item == "Baza danych oraz ustawienia programu") Response |= (1 << (int)USER.PRIV.UZYTKOWNICY);
                    if (item == "Zlecenia") Response |= (1 << (int)USER.PRIV.TRANSAKCJE);
                    if (item == "Baza pojazdów") Response |= (1 << (int)USER.PRIV.FAKTURY);
            
                }

                if (comboBox1.SelectedIndex == 0) Response ^= (1 << (int)USER.PRIV.LOGIN);

                return Response;
            }

            set
            {
                int Response = value;

                if ((Response & (1 << (int)USER.PRIV.PRODUKTY)) == (1 << (int)USER.PRIV.PRODUKTY)) lstPriv.SetItemChecked(lstPriv.Items.IndexOf("Produkty"), true);
                if ((Response & (1 << (int)USER.PRIV.MAGAZYN)) == (1 << (int)USER.PRIV.MAGAZYN)) lstPriv.SetItemChecked(lstPriv.Items.IndexOf("Magazyn"), true);
                if ((Response & (1 << (int)USER.PRIV.USŁUGI)) == (1 << (int)USER.PRIV.USŁUGI)) lstPriv.SetItemChecked(lstPriv.Items.IndexOf("Usługi"), true);
                if ((Response & (1 << (int)USER.PRIV.KONTRAHENCI)) == (1 << (int)USER.PRIV.KONTRAHENCI)) lstPriv.SetItemChecked(lstPriv.Items.IndexOf("Kontrahenci"), true);
                if ((Response & (1 << (int)USER.PRIV.PRACOWNICY)) == (1 << (int)USER.PRIV.PRACOWNICY)) lstPriv.SetItemChecked(lstPriv.Items.IndexOf("Pracownicy"), true);
                if ((Response & (1 << (int)USER.PRIV.UZYTKOWNICY)) == (1 << (int)USER.PRIV.UZYTKOWNICY)) lstPriv.SetItemChecked(lstPriv.Items.IndexOf("Baza danych oraz ustawienia programu"), true);
                if ((Response & (1 << (int)USER.PRIV.TRANSAKCJE)) == (1 << (int)USER.PRIV.TRANSAKCJE)) lstPriv.SetItemChecked(lstPriv.Items.IndexOf("Zlecenia"), true);
                if ((Response & (1 << (int)USER.PRIV.FAKTURY)) == (1 << (int)USER.PRIV.FAKTURY)) lstPriv.SetItemChecked(lstPriv.Items.IndexOf("Baza pojazdów"), true);
                if ((Response & (1 << (int)USER.PRIV.LOGIN)) == (1 << (int)USER.PRIV.LOGIN)) comboBox1.SelectedIndex = 0; else comboBox1.SelectedIndex = 1;
            }

        }

        #endregion

        public Uzytkownik(string title, string cmdName, TYPE typ)
        {
            InitializeComponent();

            this.Text = title;
            cmdDodaj.Text = cmdName;

            TrybPracy = typ;
            if (typ == TYPE.NEW)
            {
                comboBox1.SelectedIndex = 0;
            }
            else if (typ == TYPE.VIEW)
            { 
                cmdDodaj.Visible = false; cmdAnuluj.Text = "Zamknij";
                comboBox1.Enabled = false;
                txtHaslo.Enabled = false; txtPowtorzHaslo.Enabled = false;

                lstPriv.Enabled = false;
            }
            else if (typ == TYPE.EDIT)
            {
                cmdDodaj.Text = "Zapisz"; cmdAnuluj.Text = "Anuluj";
                txtLogin.Enabled = false; txtImie.Enabled = false;
                txtNazwisko.Enabled = false;
                
            }
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CheckItemsChecked()
        {
            if (lstPriv.CheckedItems.Count > 0) return true;

            Message.ErrorMessage("Lista uprawnień jest pusta");

            return false;
        }

        private void cmdDodaj_Click(object sender, EventArgs e)
        {
            if (CheckEntry.CheckEntryCtrl(new List<Control> { txtLogin, txtImie, txtNazwisko})) return;

            if (TrybPracy == TYPE.NEW)
                if (CheckEntry.CheckEntryCtrl(new List<Control> { txtHaslo, txtPowtorzHaslo })) return;

            if (CheckEntry.CheckPasswordCtrl(new List<Control> { txtHaslo, txtPowtorzHaslo })) return;

            if (!CheckItemsChecked()) return;
           

            CANCEL = false;

            Close();
        }

        private void Uzytkownik_Load(object sender, EventArgs e)
        {
            if (ADMIN)
            {
                Message.InfoMessage("Pierwszy tworzony użytkownik programu musi mieć uprawnienia administratora");

                
                comboBox1.Enabled = false;

                PRIV = (1 << (int)USER.PRIV.FAKTURY) | (1 << (int)USER.PRIV.KONTRAHENCI) | (1 << (int)USER.PRIV.LOGIN) |
                    (1 << (int)USER.PRIV.MAGAZYN) | (1 << (int)USER.PRIV.PRACOWNICY) | (1 << (int)USER.PRIV.PRODUKTY) |
                    (1 << (int)USER.PRIV.TRANSAKCJE) | (1 << (int)USER.PRIV.UZYTKOWNICY) | (1 << (int)USER.PRIV.USŁUGI);

                lstPriv.Enabled = false;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy != TYPE.VIEW) num.CheckNumberLetter(this, e);
            else e.Handled = true;
        }

        private void txtImie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy != TYPE.VIEW) num.CheckLetter(this, e);
            else e.Handled = true;
        }

        private void txtNazwisko_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TrybPracy != TYPE.VIEW) num.CheckLetter(this, e);
            else e.Handled = true;
        }

      
    }
}
