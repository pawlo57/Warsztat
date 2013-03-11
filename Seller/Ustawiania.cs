using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Seller.CONTROLS.SaveCopy;

namespace Seller
{
    public partial class Ustawiania : Form
    {
        #region PRIVATE

        private Number num = new Number();

        #endregion

        #region PUBLIC

        public bool CANCEL = true;

        public string KOPIA 
        {
            get 
            {
                if (cbFakturaKopia.CheckState == CheckState.Checked) return "1";
                else return "0";
            }

            set
            {
                if (value == "1") cbFakturaKopia.CheckState = CheckState.Checked;
                else cbFakturaKopia.CheckState = CheckState.Unchecked;
            }
        }

        #endregion

        public Ustawiania()
        {
            InitializeComponent();
        }

        private void txtNazwaFirmy_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumberLetter(this, e);
        }

        private void txtAdresFirmy_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumberLetterHash(this, e);
        }

        private void txtNIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumber(this, e);
        }

        private void txtStawkaVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumber(this, e);
        }

        private void txtTerminPlatnosci_KeyPress(object sender, KeyPressEventArgs e)
        {
            num.CheckNumber(this, e);
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdZapisz_Click(object sender, EventArgs e)
        {
            if (CheckEntry.CheckEntryCtrl(new List<Control> {txtNazwaFirmy,txtKodPocztowy,txtNIP,txtStawkaVAT,
            txtTerminPlatnosci, txtNumerKontaBankowego})) return;

            WriteSettings();

            CANCEL = false;

            Close();

            Message.InfoMessage("Ustawienia zostały zapisane");


            Settings.LoadSettings();
        }

        private bool LoadSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(Settings.adress);

            if (key == null) return false;

            try
            {
                txtNazwaFirmy.Text = key.GetValue("FIRMA").ToString();
                txtKodPocztowy.Text = key.GetValue("KOD").ToString();
                txtMiasto.Text = key.GetValue("MIASTO").ToString();
                txtUlica.Text = key.GetValue("ULICA").ToString();
                txtNIP.Text = key.GetValue("NIP").ToString();
                txtNumerKontaBankowego.Text = key.GetValue("BANK").ToString();
                txtTelefon.Text = key.GetValue("TELEFON").ToString();
                txtWWW.Text = key.GetValue("WWW").ToString();
                txtEmail.Text = key.GetValue("EMAIL").ToString();
                txtTerminPlatnosci.Text = key.GetValue("TERMIN").ToString();
                txtStawkaVAT.Text = key.GetValue("VAT").ToString();
                txtLogo.Text = key.GetValue("LOGO").ToString();
                KOPIA = key.GetValue("KOPIA").ToString();

            }
            catch { return false; }

            finally { key.Close(); }

            return true;
            
        }

        public void WriteSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(Settings.adress, true);



            if (key == null)
            {
                RegistryKey NewKey = Registry.CurrentUser.CreateSubKey(Settings.adress);

                NewKey.SetValue("FIRMA", txtNazwaFirmy.Text);
                NewKey.SetValue("KOD", txtKodPocztowy.Text);
                NewKey.SetValue("MIASTO", txtMiasto.Text);
                NewKey.SetValue("ULICA", txtUlica.Text);
                NewKey.SetValue("NIP", txtNIP.Text);
                NewKey.SetValue("BANK", txtNumerKontaBankowego.Text);
                NewKey.SetValue("TELEFON", txtTelefon.Text);
                NewKey.SetValue("WWW", txtWWW.Text);
                NewKey.SetValue("EMAIL", txtEmail.Text);
                NewKey.SetValue("TERMIN", txtTerminPlatnosci.Text);
                NewKey.SetValue("VAT", txtStawkaVAT.Text);
                NewKey.SetValue("WERSJA", Settings.WERSJA);
                NewKey.SetValue("LOGO", txtLogo.Text);
                NewKey.SetValue("KOPIA", KOPIA);
            }
            else
            {
                key.SetValue("FIRMA", txtNazwaFirmy.Text);
                key.SetValue("KOD", txtKodPocztowy.Text);
                key.SetValue("MIASTO", txtMiasto.Text);
                key.SetValue("ULICA", txtUlica.Text);
                key.SetValue("NIP", txtNIP.Text);
                key.SetValue("BANK", txtNumerKontaBankowego.Text);
                key.SetValue("TELEFON", txtTelefon.Text);
                key.SetValue("WWW", txtWWW.Text);
                key.SetValue("EMAIL", txtEmail.Text);
                key.SetValue("TERMIN", txtTerminPlatnosci.Text);
                key.SetValue("VAT", txtStawkaVAT.Text);
                key.SetValue("WERSJA", Settings.WERSJA);
                key.SetValue("LOGO", txtLogo.Text);
                key.SetValue("KOPIA", KOPIA);
            }
        }

        private void Ustawiania_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void txtLogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmdLogo_Click(object sender, EventArgs e)
        {
            SaveCopyFrm loadLogo = new SaveCopyFrm(SaveCopyFrm.TYPE.LOGO_FILE);

            loadLogo.ShowDialog();

            if (loadLogo.RESULT == false) return;

            txtLogo.Text = loadLogo.LOGO_FILE;

        }

        private void cmdLogoKasuj_Click(object sender, EventArgs e)
        {
            txtLogo.Text = "";
        }

       
    }
}
