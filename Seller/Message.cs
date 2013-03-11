using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace Seller
{
    static class Message
    {
        static Message() { }

        public static void ErrorMessage(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InfoMessage(string message)
        {
            MessageBox.Show(message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool AskMessage(string message)
        {
            if (MessageBox.Show(message, "", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) return true;
            
            return false;
        }

        public static void ErrorConnection()
        {
            ErrorMessage("Błąd połączenia");
        }

        public static void Position()
        {
            ErrorMessage("Proszę zanaczyć pozycję z listy");
        }

        public static void NotAll()
        {
            ErrorMessage("Proszę uzupełnić brakujące pola (zaznaczone na żółto)");
        }

        public static void NotFound()
        {
            ErrorMessage("Nie znaleziono");
        }

        public static void ErrorDatabase()
        {
            ErrorMessage("Błąd dodawania danych do bazy");
        }

        public static void PrivError()
        {
            ErrorMessage("Niewystarczające uprawnienia do uruchomienia tej opcji");
        }

        public static bool EndMessage()
        {
            if (AskMessage("Czy napewno zakończyć program?")) return true;

            return false;
        }

        public static void ProcessErrorMessage(ErrorCode.CODE Result)
        {
            if (Result == ErrorCode.CODE.EXIST) Message.InfoMessage("Podana pozycja już istnieje");
            else if (Result == ErrorCode.CODE.LOGIN) Message.ErrorMessage("Błąd logowania");
            else if (Result == ErrorCode.CODE.SUCCES) Message.InfoMessage("Pomyślnie dodano nową pozycję");
        }

       
    }
}
