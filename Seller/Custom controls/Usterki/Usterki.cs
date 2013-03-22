using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.Class;

namespace Seller.CONTROLS.Usterki
{
    public partial class Usterki : Form
    {
        public Usterki(int carid, TYPE Tryb)
        {
            InitializeComponent();

            this.CARID = carid;
            this.TrybPracy = Tryb;
        }

        public enum TYPE
        {
            EDIT,
            VIEW
        }

        public TYPE TrybPracy = TYPE.EDIT;

        #region ACCESS

        public int CARID { get; set; }

        #endregion

        private void LadujUsterki()
        {
            dgvUsterki.DataSource = null;

            dgvUsterki.DataSource = CustomerDatabase.GetUsterki(CARID);

            if (dgvUsterki.Columns.Count == 0) return;

            for (int i = 0; i < dgvUsterki.Columns.Count; i++) dgvUsterki.Columns[i].Visible = false;

            dgvUsterki.Columns["USTERKA"].Visible = true;
            dgvUsterki.Columns["USTERKA"].HeaderText = "Usterka";
        }

        private void cmdUstarkaDodaj_Click(object sender, EventArgs e)
        {
            UsterkaAddView addUsterka = new UsterkaAddView(UsterkaAddView.TYPE.ADD);

            addUsterka.ShowDialog();

            if (addUsterka.CANCEL) return;

            CustomerDatabase.NewUsterka(CARID, addUsterka.USTERKA);

            LadujUsterki();
        }

        private void Usterki_Load(object sender, EventArgs e)
        {
            LadujUsterki();

            switch (TrybPracy)
            {
                case TYPE.EDIT:
                    break;

                case TYPE.VIEW:
                    cmdUstarkaDodaj.Visible = false;
                    cmdUsterkaUsun.Visible = false;
                    break;
            }
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdUsterkaUsun_Click(object sender, EventArgs e)
        {
            UsterkaCls usterka = null;

            try { usterka = (UsterkaCls)dgvUsterki.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            if (!Message.AskMessage("Czy napewno usunąć wybraną pozycję?")) return;

            CustomerDatabase.DeleteUsterka(usterka.ID);

            LadujUsterki();
        }

        private void cmdUsterkaPodgląd_Click(object sender, EventArgs e)
        {
            UsterkaCls usterka = null;

            try { usterka = (UsterkaCls)dgvUsterki.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            UsterkaAddView usterkaFrm = new UsterkaAddView(UsterkaAddView.TYPE.VIEW);

            usterkaFrm.USTERKA = usterka.USTERKA;

            usterkaFrm.ShowDialog();
        }
    }
}
