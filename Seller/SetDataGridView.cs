using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.Class;

namespace Seller
{
    public static class SetDataGridView
    {

        private static void ClearColumns(ref DataGridView datagrid)
        {
            for (int i = 0; i < datagrid.Columns.Count; i++)
                datagrid.Columns[i].Visible = false;
        }

        private static void SetColumnName(ref DataGridView datagrid, List<ColumnCls> Columns)
        {
            if (datagrid.Columns.Count == 0) return;

            ClearColumns(ref datagrid);

            for (int i = 0; i < Columns.Count; i++)
            {
                datagrid.Columns[Columns[i].COLUMN].Visible = true;
                datagrid.Columns[Columns[i].COLUMN].HeaderText = Columns[i].DSC;
            }
        }

        public static void SetProduktyView(ref DataGridView datagrid)
        {
            
            List<ColumnCls> columns = new List<ColumnCls> 
            {
                new ColumnCls { COLUMN = "CNAME", DSC = "Dostawca" },
                new ColumnCls { COLUMN = "NAME", DSC = "Nazwa produktu" },
                new ColumnCls { COLUMN = "VATPRICE", DSC = "Cena zakupu" },
                new ColumnCls {COLUMN = "VATPRICE2", DSC = "Cena sprzedaży" },
            };

            SetColumnName(ref datagrid, columns);
        }

        public static void SetKategorieView(ref DataGridView datagrid)
        {
            if (datagrid.Columns.Count == 0) return;

            datagrid.Columns["ID"].Visible = false;
            datagrid.Columns["NAME"].HeaderText = "Kategoria";
        }

        public static void SetTowaryView(ref DataGridView datagrid)
        {

            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "CATNAME", DSC = "Kategoria" },
                new ColumnCls { COLUMN = "CNAME", DSC = "Dostawca" },
                new ColumnCls { COLUMN = "COUNT", DSC = "Stan magazynu" },
                new ColumnCls { COLUMN = "MAGAZYN", DSC = "Magazyn" },
                new ColumnCls { COLUMN = "NAME", DSC = "Nazwa towaru" },
                new ColumnCls { COLUMN = "VATPRICE2", DSC = "Cena sprzedaży" },
                new ColumnCls { COLUMN = "VATPRICE" , DSC = "Cena zakupu" },
            };

            SetColumnName(ref datagrid, columns);
        }

        public static void SetPzWzView(ref DataGridView datagrid)
        {
            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "CNAME", DSC = "Kontrahent" },
                new ColumnCls { COLUMN = "DATA", DSC = "Data" },
                new ColumnCls { COLUMN = "MAGAZYN", DSC = "Magazyn" },
                new ColumnCls { COLUMN = "SUMA", DSC = "Wartość całkowita" }
            };

            SetColumnName(ref datagrid, columns);

        }

        public static void SetKontrahentView(ref DataGridView datagrid)
        {
            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "ADRES", DSC = "Adres" },
                new ColumnCls { COLUMN = "FIRMA", DSC = "Firma" },
                new ColumnCls { COLUMN = "IMIE", DSC = "Imię" },
                new ColumnCls { COLUMN = "NAZWISKO", DSC = "Nazwisko" }
            };

            SetColumnName(ref datagrid, columns);
        }

        public static void SetAddedProduktView(ref DataGridView datagrid)
        {
            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "VATPRICE2", DSC = "Cena sprzedaży" },
                new ColumnCls { COLUMN = "NAME", DSC = "Nazwa towaru" },
                new ColumnCls { COLUMN = "PRICE", DSC = "Cena zakupu" },
                new ColumnCls { COLUMN = "STAN", DSC = "Ilość" },
                new ColumnCls { COLUMN = "SUMA", DSC = "Suma" }
            };

            SetColumnName(ref datagrid, columns);
        }

        public static void SetAddedTowarView(ref DataGridView datagrid)
        {
            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "NAME", DSC = "Nazwa" },
                new ColumnCls { COLUMN = "STAN", DSC = "Ilość" },
                new ColumnCls { COLUMN = "SUMA", DSC = "Suma brutto" },
                new ColumnCls { COLUMN = "VATPRICE2", DSC = "Cena" }
            };

            SetColumnName(ref datagrid, columns);
        }

        public static void SetMagazynyView(ref DataGridView datagrid)
        {
            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "ADRES", DSC = "Adres" },
                new ColumnCls { COLUMN = "MAGAZYN", DSC = "Magazyn" }
            };

            SetColumnName(ref datagrid, columns);

        }

        public static void SetWorkersView(ref DataGridView datagrid)
        {
            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "IMIE", DSC = "Imię" },
                new ColumnCls { COLUMN = "NAZWISKO", DSC = "Nazwisko" },
                new ColumnCls { COLUMN = "ADRES", DSC = "Adres" }
            };

            SetColumnName(ref datagrid, columns);
        }

        public static void SetCustomersView(ref DataGridView datagrid)
        {
            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "FIRMA", DSC = "Nazwa firmy" },
                new ColumnCls { COLUMN = "IMIE", DSC = "Imię" },
                new ColumnCls { COLUMN = "NAZWISKO", DSC = "Nazwisko" },
                new ColumnCls { COLUMN = "ADRES", DSC = "Adres" },
                new ColumnCls { COLUMN = "TELEFON", DSC = "Nr. telefonu" }
            };

            SetColumnName(ref datagrid, columns);
        }

        public static void SetTransakcjeView(ref DataGridView datagrid)
        {
            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "CNAME", DSC = "Kontrahent (właściciel)" },
                new ColumnCls { COLUMN = "DATA", DSC = "Data zlecenia" },
                new ColumnCls { COLUMN = "NUMER", DSC = "Numer zlecenia" },
                new ColumnCls { COLUMN = "VATPRICE", DSC = "Suma brutto" },
                new ColumnCls { COLUMN = "CAR_NAME", DSC = "Pojazd" },
                new ColumnCls { COLUMN = "TERMIN", DSC = "Termin zapłaty" },
                new ColumnCls { COLUMN = "TERMIN_UKONCZENIA", DSC = "Termin ukończenia" }
            };

            SetColumnName(ref datagrid, columns);
           
        }

        public static void SetTransakcjeViewKsiazka(ref DataGridView datagrid)
        {
            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "DATA", DSC = "Data zlecenia" },
                new ColumnCls { COLUMN = "NUMER", DSC = "Numer zlecenia" },
                new ColumnCls { COLUMN = "VATPRICE", DSC = "Suma brutto" }
            };

            SetColumnName(ref datagrid, columns);

        }

      

        public static void SetUsersView(ref DataGridView datagrid)
        {
            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "LOGIN", DSC = "Nazwa użytkownika" },
                new ColumnCls { COLUMN = "IMIE", DSC = "Imię" },
                new ColumnCls { COLUMN = "NAZWISKO", DSC = "Nazwisko" }
            };

            SetColumnName(ref datagrid, columns);
        }

        public static void SetUslugiView(ref DataGridView datagrid)
        {
            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "Numer", DSC = "Numer usługi" },
                new ColumnCls { COLUMN = "Nazwa", DSC = "Nazwa usługi" },
                new ColumnCls { COLUMN = "VAT", DSC = "Stawka VAT" },
                new ColumnCls { COLUMN = "Brutto", DSC = "Cena brutto" },
                new ColumnCls { COLUMN = "W_NAME", DSC = "Pracownik" }
            };

            SetColumnName(ref datagrid, columns);
        }

        public static void SetCarsView(ref DataGridView datagrid)
        {
            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "MARKA", DSC = "Marka" },
                new ColumnCls { COLUMN = "MODEL", DSC = "Model" },
                new ColumnCls { COLUMN = "POJEMNOSC", DSC = "Pojemność" },
                new ColumnCls { COLUMN = "TYP", DSC = "Typ" },
                new ColumnCls { COLUMN = "ROK", DSC = "Rok produkcji" },
                new ColumnCls { COLUMN = "REJESTRACJA", DSC = "Numer rejestracyjny" },
                new ColumnCls { COLUMN = "BADANIE", DSC = "Termin badania technicznego" },
                new ColumnCls { COLUMN = "KONTRAHENT", DSC = "Kontrahent (właściciel)" }
            };

            SetColumnName(ref datagrid, columns);
        }



        public static void SetWorkerReportView(ref DataGridView datagrid)
        {
            List<ColumnCls> columns = new List<ColumnCls>
            {
                new ColumnCls { COLUMN = "DATA", DSC = "Data" },
                new ColumnCls { COLUMN = "IMIE", DSC = "Imię" },
                new ColumnCls { COLUMN = "NAZWISKO", DSC = "Nazwisko" },
                new ColumnCls { COLUMN = "ADRES", DSC = "Adres" },
                new ColumnCls { COLUMN = "NUMER", DSC = "Numer usługi" },
                new ColumnCls { COLUMN = "NAZWA", DSC = "Nazwa usługi" },
                new ColumnCls { COLUMN = "Brutto", DSC = "Kwota" },
                new ColumnCls { COLUMN = "CZAS", DSC = "Czas wykonania" }
            };

            SetColumnName(ref datagrid, columns);
        }




    }
}
