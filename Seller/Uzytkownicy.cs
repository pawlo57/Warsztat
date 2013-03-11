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
    public partial class Uzytkownicy : Form
    {
        public bool EMPTYLIST = true;


        public Uzytkownicy()
        {
            InitializeComponent();
        }

        private void LoadUzytkownicy()
        {
            dgvUzytkownicy.DataSource = null;

            dgvUzytkownicy.DataSource = CustomerDatabase.GetUserList();

            SetDataGridView.SetUsersView(ref dgvUzytkownicy);
        }

        private void Uzytkownicy_Load(object sender, EventArgs e)
        {
            LoadUzytkownicy();

            if (USER.Users.Length < 2)
            {
                this.Visible = false;
                cmdNowy_Click(this, e);
            }
        }

        private void cmdKoniec_Click(object sender, EventArgs e)
        {
            if (dgvUzytkownicy.Rows.Count == 0)
            {
                if (Message.AskMessage("Lista użytkowników jest pusta. Nastąpi wyjście z programu.\n Czy napewno zakończyć?"))
                    EMPTYLIST = true;
                else return;
            }
            else EMPTYLIST = false;


            Close();
        }

        private void cmdNowy_Click(object sender, EventArgs e)
        {
            Uzytkownik uzytkownik = new Uzytkownik("Nowy użytkownik", "Wprowadź",Uzytkownik.TYPE.NEW);

            if (dgvUzytkownicy.Rows.Count == 0) uzytkownik.ADMIN = true;

            uzytkownik.ShowDialog();

            if (uzytkownik.CANCEL && !this.Visible) { cmdKoniec_Click(this, e); return; }

            if (uzytkownik.CANCEL) return;

            CustomerDatabase.NewUser(uzytkownik.UZYTKOWNIK.LOGIN, uzytkownik.UZYTKOWNIK.password,
                uzytkownik.UZYTKOWNIK.IMIE, uzytkownik.UZYTKOWNIK.NAZWISKO, uzytkownik.PRIV);

            Message.InfoMessage("Pomyślnie dodano nowego użytkownika");

            if (this.Visible) LoadUzytkownicy();
            else { EMPTYLIST = false; Close(); }



        }

        private void cmdPodglad_Click(object sender, EventArgs e)
        {
            Users user = null;

            try { user = (Users)dgvUzytkownicy.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            Uzytkownik uzytkownik = new Uzytkownik("Podgląd uzytkownika", "",Uzytkownik.TYPE.VIEW);

            uzytkownik.UZYTKOWNIK = user;

            uzytkownik.ShowDialog();
        }


        private void cmdEdycja_Click(object sender, EventArgs e)
        {
            Users user = null;

            try { user = (Users)dgvUzytkownicy.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            Uzytkownik uzytkownik = new Uzytkownik("Edycja użytkownika", "", Uzytkownik.TYPE.EDIT);

            uzytkownik.UZYTKOWNIK = user;

            uzytkownik.ShowDialog();

            if (uzytkownik.CANCEL) return;

            bool adm = true;

            for (int i = 0; i < dgvUzytkownicy.Rows.Count; i++)
            {
                Users usr = (Users)dgvUzytkownicy.Rows[i].DataBoundItem;

                if (usr.ID == user.ID) continue;

                if (((usr.PRIV & (1 << (int)USER.PRIV.LOGIN)) == (1 << (int)USER.PRIV.LOGIN)) &&
                    ((usr.PRIV & (1 << (int)USER.PRIV.UZYTKOWNICY)) == (1 << (int)USER.PRIV.UZYTKOWNICY))) { adm = true; break; }
                else adm = false;
            }

            if (!adm) { Message.ErrorMessage("Żaden z użytkowników nie posiada uprawnień administratora.\n Operacja edycji została anulowana"); return; }

            CustomerDatabase.UpdateUser(user.ID, uzytkownik.UZYTKOWNIK.password, uzytkownik.UZYTKOWNIK.PRIV);

            LoadUzytkownicy();

            Message.InfoMessage("Pomyślnie zapisano użytkownika");
        }
    }
}
