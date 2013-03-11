using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seller.CONTROLS
{
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void LoadCustomers(int ID, string firma, string imie, string nazwisko, string nip, string pesel,
            string bank)
        {
            List<Klient> customers = CustomerDatabase.GetCustomers(ID, firma, imie, nazwisko, nip, pesel, bank);
            
            if (customers == null) { Message.InfoMessage("Nie znaleziono"); return; }

            dgwCustomers.DataSource = customers;

            SetDataGridView.SetCustomersView(ref dgwCustomers);
        }

        private void cmdSzukaj_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(Customer.TYPE.FIND);

            customer.ShowDialog();

            if (customer.CANCEL) return;

            LoadCustomers(-1, customer.FIRMA, customer.IMIE, customer.NAZWISKO, customer.NIP, customer.PESEL, customer.BANK);
        }

        private void cmdNowy_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer(Customer.TYPE.NEW);

            newCustomer.ShowDialog();

            if (newCustomer.CANCEL) return;

            int Result = CustomerDatabase.NewCustomer(newCustomer.FIRMA, newCustomer.IMIE, newCustomer.NAZWISKO, 
                newCustomer.ADRES, newCustomer.NIP, newCustomer.PESEL, newCustomer.BANK,newCustomer.TELEFON);
           

            if (Result < 0) { Message.ErrorDatabase(); return; }

            LoadCustomers(-1, newCustomer.FIRMA, newCustomer.IMIE, newCustomer.NAZWISKO, newCustomer.NIP,
                newCustomer.PESEL, newCustomer.BANK);

            Message.InfoMessage("Nowy kontrahent został dodany");

            
        }

        private void SendErrorMessage(ErrorCode.CODE Result)
        {
            if (Result == ErrorCode.CODE.LOGIN) { Message.ErrorMessage("Błąd logowania"); return; }
            else if (Result == ErrorCode.CODE.EXIST) { Message.ErrorMessage("Podany kontrahent juz istnieje"); return; }

        }

        private void cmdEdytuj_Click(object sender, EventArgs e)
        {
            Klient customer;

            try { customer = (Klient)dgwCustomers.CurrentRow.DataBoundItem; }
            catch { return; }

            Customer newCustomer = new Customer(Customer.TYPE.EDIT);

            newCustomer.FIRMA = customer.FIRMA;
            newCustomer.IMIE = customer.IMIE;
            newCustomer.NAZWISKO = customer.NAZWISKO;
            newCustomer.ADRES = customer.ADRES;
            newCustomer.NIP = customer.NIP;
            newCustomer.PESEL = customer.PESEL;
            newCustomer.BANK = customer.BANK;
            newCustomer.TELEFON = customer.TELEFON;

            newCustomer.ShowDialog();

            if (newCustomer.CANCEL) return;

            Klient client = new Klient();


            CustomerDatabase.UpdateCustomer(customer.ID, newCustomer.FIRMA, newCustomer.IMIE, newCustomer.NAZWISKO,
                    newCustomer.ADRES,
                    newCustomer.NIP, newCustomer.PESEL, newCustomer.BANK,newCustomer.TELEFON);

            LoadCustomers(-1, newCustomer.FIRMA, newCustomer.IMIE, newCustomer.NAZWISKO, newCustomer.NIP, newCustomer.PESEL,
                newCustomer.BANK);

            Message.InfoMessage("Kontrahent został zapisany");
        }
    }
}
