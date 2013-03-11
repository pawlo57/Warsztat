using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.IO;

namespace Seller
{
    public static class Settings
    {
        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private const int CB_SHOWDROPDOWN = 0x014F;

        public static void ShowDropDownList(ref ComboBox cbxCombo)
        {
            SendMessage(cbxCombo.Handle, CB_SHOWDROPDOWN, (IntPtr)1,
            IntPtr.Zero);
        }

        public static string AppDirectory = Directory.GetCurrentDirectory();

        public static string WERSJA = "1.3";

        public static string Nazwa_Programu = "Warsztat samochodowy ver." + WERSJA;

        public static string adress = "Software\\Complex\\Warsztat";

        private static int termin = -1;

        public static string FRIMA { get; set; }

        public static string KOD_POCZTOWY { get; set; }

        public static string MIASTO { get; set; }

        public static string ULICA { get; set; }

        public static string NIP { get; set; }

        public static string BANK { get; set; }

        public static string TELEFON { get; set; }

        public static string WWW { get; set; }

        public static string EMAIL { get; set; }

        public static string LOGO { get; set; }

        public static string ADRES { get { return KOD_POCZTOWY + " " + MIASTO + "," + ULICA; } }

        public static string TERMIN { get { return DateTime.Today.AddDays(termin).ToShortDateString(); } }

        public static int X;

        public static int Y;

        public static int WITH;

        public static int HEGIHT;

        public static int PROCENT { get; set; }

        public static int KOPIA { get; set; }

        public static List<Category> CATEORIES = new List<Category>();

        public static List<Mgzyn> MAGAZYNY = new List<Mgzyn>();

        public static int SELECTEDCATEGORY = -1;

        public static bool LoadSettings()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(adress);

            if (key == null) return false;

            try
            {
                FRIMA = key.GetValue("FIRMA").ToString();
                KOD_POCZTOWY = key.GetValue("KOD").ToString();
                MIASTO = key.GetValue("MIASTO").ToString();
                ULICA = key.GetValue("ULICA").ToString();
                NIP = key.GetValue("NIP").ToString();
                BANK = key.GetValue("BANK").ToString();
                TELEFON = key.GetValue("TELEFON").ToString();
                WWW = key.GetValue("WWW").ToString();
                EMAIL = key.GetValue("EMAIL").ToString();
                termin = int.Parse(key.GetValue("TERMIN").ToString());
                PROCENT = int.Parse(key.GetValue("VAT").ToString());
                X = int.Parse(key.GetValue("X").ToString());
                Y = int.Parse(key.GetValue("Y").ToString());
                WITH = int.Parse(key.GetValue("WIDTH").ToString());
                HEGIHT = int.Parse(key.GetValue("HEIGHT").ToString());
                LOGO = key.GetValue("LOGO").ToString();

                if (key.GetValue("KOPIA").ToString() == "1") KOPIA = 2;
                else KOPIA = 1;
            }
            catch { return false; }

            finally { key.Close(); }

            return true;

        }

        public static void WriteSize(int x, int y, int with, int height)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(Settings.adress, true);

            if (key == null)
            {
                RegistryKey NewKey = Registry.CurrentUser.CreateSubKey(Settings.adress);

                NewKey.SetValue("X", x);
                NewKey.SetValue("Y", y);
                NewKey.SetValue("WIDTH", with);
                NewKey.SetValue("HEIGHT", height);
              
            }
            else
            {
                key.SetValue("X", x);
                key.SetValue("Y", y);
                key.SetValue("WIDTH", with);
                key.SetValue("HEIGHT", height);
            }
        }


        public static void LoadCategories()
        {
            CATEORIES.Clear();

            List<Category> categorie = CustomerDatabase.GetCategories(""); 

            if (categorie != null) Settings.CATEORIES.AddRange(categorie);
  
        }

        public static void LoadMagazyny()
        {
            MAGAZYNY.Clear();

            List<Mgzyn> magazyny = CustomerDatabase.GetMagazyny("", "");

            if (magazyny != null) MAGAZYNY.AddRange(magazyny);
        }
    }

   
}
