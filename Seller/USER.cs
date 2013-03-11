using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seller
{
    public static class USER
    {
        public static string USR = "";
        public static string PASSWORD = "";

        public static Users[] Users { set; get; }

        public static Users User = new Users();

        public enum PRIV
        {
            ADMIN,
            PRODUKTY,
            UZYTKOWNICY,
            MAGAZYN,
            USŁUGI,
            PRACOWNICY,
            KONTRAHENCI,
            TRANSAKCJE,
            FAKTURY,
            LOGIN,
            BAZA_DANYCH
        }


        static USER()
        {  
        }

        public static bool LoginUser()
        {
            if (Users == null) return false;

            if (Users.Length < 2) 
            {
                Message.InfoMessage("Baza użytkowników jest pusta. Proszę dodać użytkowników do obsługi tego programu");


                Uzytkownicy uzytkownicy = new Uzytkownicy();

                uzytkownicy.ShowDialog();

                if (uzytkownicy.EMPTYLIST) return false;
            }

            Logowanie:

            Login logowanie = new Login();

            logowanie.ShowDialog();

            if (logowanie.CANCEL) return false;

            Users uzytkownik = CustomerDatabase.Login(logowanie.USER, logowanie.PASSWORD);

            if (uzytkownik == null) { Message.ErrorMessage("Nieprawidłowy login lub hasło"); logowanie.Dispose(); goto Logowanie; }

            if (((uzytkownik.PRIV & (1 << (int)USER.PRIV.LOGIN)) != (1 << (int)USER.PRIV.LOGIN)))
            { Message.ErrorMessage("Użykownik nie może się zalogować gdyż jest nieaktywny"); logowanie.Dispose(); goto Logowanie; }

            User.ID = uzytkownik.ID;
            User.IMIE = uzytkownik.IMIE;
            User.NAZWISKO = uzytkownik.NAZWISKO;
            User.LOGIN = logowanie.USER;
            User.password = logowanie.PASSWORD;
            User.PRIV = uzytkownik.PRIV;

            USR = logowanie.USER; ;
            PASSWORD = logowanie.PASSWORD;

            LoadUsers();

            return true;
    
        }


        public static void LoadUsers()
        {
            List<Users> users = new List<Users>();

            users.Add(new Users { ID = 0, IMIE = "Wszyscy" });

            List<Users> Users = CustomerDatabase.GetUsers();

            if (Users != null) users.AddRange(Users);

            USER.Users = users.ToArray();
        }
    }
}
