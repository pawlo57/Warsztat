using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Seller
{
    public static class CheckEntry
    {
        private static List<Control> ctrlList = new List<Control>();

        public static bool CheckEntryCtrl(List<Control> list)
        {
            ctrlList.Clear();

            ClearControls(list);

            for (int i = 0; i < list.Count; i++)
                if (String.IsNullOrEmpty(list[i].Text))
                    ctrlList.Add(list[i]);

            if (ctrlList.Count > 0) 
            {
                for (int i = 0; i < ctrlList.Count; i++) MarkControl(ctrlList[i]);

                Message.NotAll();

                return true;
            }

            return false;
        }

        public static bool CheckPasswordCtrl(List<Control> list)
        {
            ctrlList.Clear();

            ClearControls(list);

            for (int i = 0; i < list.Count; i++)
                if (String.IsNullOrEmpty(list[i].Text))
                    ctrlList.Add(list[i]);

            string password = ((TextBox)list[0]).Text;

            string RepeatPassword = ((TextBox)list[1]).Text;

            if (password == RepeatPassword)             
                return false;
            

            MarkControl(list[0]);
            MarkControl(list[1]);

            Message.ErrorMessage("Wprowadzone hasła się nie zgadzają");

            return true;
        }

        private static void MarkControl(Control control)
        {
            control.BackColor = Color.Yellow;
        }


        private static void ClearControls(List<Control> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                Control ctrl = lst[i];
                ctrl.BackColor = Color.White;
            }

            ctrlList.Clear();
        }

        public static void SetForAll(List<Control> lst)
        {
            for (int i = 0; i < lst.Count; i++)
                lst[i].Text = "Wszystkie";
        }

        public static void ClearForAll(List<Control> lst)
        {
            for (int i = 0; i < lst.Count; i++)
                if (lst[i].Text == "Wszystkie" || lst[i].Text == "Wszyscy")
                    lst[i].Text = "";
        }
    }
}
