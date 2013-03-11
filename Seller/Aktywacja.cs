using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace Seller
{
    class Aktywacja
    {
        private string adress = "Software\\WS\\WR";

        public string KOD = "3450994512-1SB";

        public bool ReadRegisty()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(adress);

            if (key == null)
            {
                RegistryKey NewKey = Registry.CurrentUser.CreateSubKey(adress);

                NewKey.SetValue("DATE", DateTime.Today.Date);

                NewKey.Close();

                return true;
            }
            else
            {
                DateTime Date;

                int days = -1;

                try
                {
                    Date = DateTime.Parse(key.GetValue("DATE").ToString());

                    TimeSpan time = DateTime.Today - Date;

                    days = time.Days;
                }
                catch { days = 100; }

                finally { key.Close(); }

                if (days > 20 || days < 0) return CheckActivte();
                else return true;

            }

        }

        public void WriteRegisty()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(adress, true);

            if (key == null)
            {
                RegistryKey NewKey = Registry.CurrentUser.CreateSubKey(adress);

                NewKey.SetValue("CDD", KOD);
            }
            else
            {
                key.SetValue("CDD", KOD);
            }
        }

        public bool CheckActivte()
        {
            Activate acvivate = new Activate();

            RegistryKey key = Registry.CurrentUser.OpenSubKey(adress);

            string kode = null;

            try { kode = key.GetValue("CDD").ToString(); }
            catch { kode = null; }
            finally { key.Close(); }

            if (kode == null || kode != KOD)
            {
                acvivate.ShowDialog();

                if (acvivate.CANCEL) return false;

            }

            return true;
        }
    }
}
