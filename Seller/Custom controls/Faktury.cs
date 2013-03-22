using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.CONTROLS.Samochody;
using Seller.Class;

namespace Seller.CONTROLS
{
    public partial class Faktury : UserControl
    {
        #region PRIVATE

        private Stampa.ReportDocument document = new Stampa.ReportDocument();

        //List<KsiegaCls> ksiega

        private string TITLE = "";

        #endregion

        public Faktury()
        {
            InitializeComponent();
        }

        private void cmdNowy_Click(object sender, EventArgs e)
        {
            CarsFrm NewCar = new CarsFrm(CarsFrm.TYPE.NEW);

            NewCar.ShowDialog();

            if (NewCar.CANCEL) return;

            int id = CustomerDatabase.NewCar(NewCar.CID, NewCar.MARKA, NewCar.MODEL,
                NewCar.POJEMNOSC, NewCar.TYP, NewCar.ROK_PRODUKCJI, NewCar.REJESTRACJA,
                NewCar.VIN, NewCar.OPIS, NewCar.SILNIK, NewCar.BADANIE, -1,
                -1, NewCar.DATA_PRZYJECIA, NewCar.DATA_WYDANIA, 0);

            LoadCar(id, -1, "", "", "", "", "", "", "", "","","");

            Message.InfoMessage("Nowy pojazd został dodany do bazy");
        }

        private void LoadCar(int ID, int CID, string MARKA, string MODEL, string POJ,
            string TYP, string ROK, string REJESTRACJA, string VIN, string SILNIK, string BADANIE_OD,string BADANIE_DO)
        {
            List<Car> cars =
                CustomerDatabase.GetCars(ID, CID, MARKA, MODEL, POJ, TYP, ROK, REJESTRACJA, VIN, SILNIK, BADANIE_OD,BADANIE_DO);

            if (cars == null)
            { Message.NotFound(); dgwTransactions.DataSource = null; return; }

            dgwTransactions.DataSource = cars;

            SetDataGridView.SetCarsView(ref dgwTransactions);

        }

        private void cmdFaktura_Click(object sender, EventArgs e)
        {
            Car car = null;

            try { car = (Car)dgwTransactions.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            CarsFrm cars = new CarsFrm(CarsFrm.TYPE.PRINT);

            cars.CAR = car;

            cars.ShowDialog();

            if (cars.CANCEL) return;

            Drukuj.PrintCar(car);
        }


      

        private void cmdSzukaj_Click(object sender, EventArgs e)
        {
            CarsFrm findCar = new CarsFrm(CarsFrm.TYPE.FIND);

            findCar.ShowDialog();

            if (findCar.CANCEL) return;

            LoadCar(-1, findCar.CID, findCar.MARKA, findCar.MODEL, findCar.POJEMNOSC,
                findCar.TYP, findCar.ROK_PRODUKCJI, findCar.REJESTRACJA, findCar.VIN,
                findCar.SILNIK,"","");
        }

        private void cmdPodglad_Click(object sender, EventArgs e)
        {
            Car car = null;

            try { car = (Car)dgwTransactions.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            CarsFrm cars = new CarsFrm(CarsFrm.TYPE.VIEW);

            cars.CAR = car;

            cars.ShowDialog();
        }

        private void cmdEdycja_Click(object sender, EventArgs e)
        {
            Car car = null;

            try { car = (Car)dgwTransactions.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            CarsFrm cars = new CarsFrm(CarsFrm.TYPE.EDIT);

            cars.CAR = car;

            cars.ShowDialog();

            if (cars.CANCEL) return;

            CustomerDatabase.UpdateCar(car.ID, cars.CID, cars.MARKA, cars.MODEL, cars.POJEMNOSC,
                cars.TYP, cars.ROK_PRODUKCJI, cars.REJESTRACJA, cars.VIN, cars.OPIS,
                cars.SILNIK, cars.BADANIE, -1, -1, cars.DATA_PRZYJECIA,
                cars.DATA_WYDANIA, -1);

            LoadCar(car.ID, -1, "", "", "", "", "", "", "", "","","");

            Message.InfoMessage("Dane pojazdu zostały zapisane");
        }

        private void cmdSzukajRok_Click(object sender, EventArgs e)
        {
            string startDate = DateTime.Today.Year + "-01-01";

            string endDate = DateTime.Today.Year + "-12-31";

            //LoadUmarli(-1, "", "", "", "", "", "", "", "", -1, -1, -1, -1, -1, -1, -1, -1, -1,
            //    startDate, endDate, -1);

            TITLE = "Lista abonamentów kończących się w tym roku";
        }

       
        //private void cmdPrintLst_Click(object sender, EventArgs e)
        //{
        //    if (dgwTransactions.Rows.Count == 0) { Message.ErrorMessage("Brak danych do drukowania"); return; }

        //    List<KsiegaCls> ksiegaPrint = (List<KsiegaCls>)dgwTransactions.DataSource;

        //    //Drukuj.PrintUmarlyLista(ksiegaPrint, TITLE);
        //}

        private void cmdListaNapraw_Click(object sender, EventArgs e)
        {
            Car car = null;

            try { car = (Car)dgwTransactions.CurrentRow.DataBoundItem; }
            catch { Message.Position(); return; }

            KsiazkaSerwisowa ksiazka = new KsiazkaSerwisowa();

            ksiazka.CAR = car;

            ksiazka.ShowDialog();
        }

        private void cmdBadaniaSzukaj_Click(object sender, EventArgs e)
        {
            BadaniaFrm badanie = new BadaniaFrm();

            badanie.ShowDialog();

            switch (badanie.RESULT)
            {
                case BadaniaFrm.TYPE.CANCEL:
                    return;
                    
                case BadaniaFrm.TYPE.QUICK:
                    string startDate = DateTime.Today.Year + "-01-01";

                    string endDate = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" +
                        DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
                    LoadCar(-1, -1, "", "", "", "", "", "", "", "", startDate, endDate);
                    break;

                case BadaniaFrm.TYPE.DETAIL:
                    LoadCar(-1, -1, "", "", "", "", "", "", "", "", badanie.DATA_OD, badanie.DATA_DO);
                    break;
            }

            if (dgwTransactions.RowCount > 0)
                Message.InfoMessage("Znaleziono pojazdów: " + dgwTransactions.RowCount);
        }

       


    }
}
