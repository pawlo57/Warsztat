using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seller
{
    public static class MathHelp
    {
        private static Number num = new Number();

        public static string Mul(float x, float y)
        {
            return AddZero(Math.Round(x * y, 2).ToString());
        }

        public static string AddZero(string number)
        {
            int index = number.IndexOf(',');

            if (index < 0) return number + ",00";

            int count = number.Length - index;

            if (count == 2) return number + "0";

            return number;
        }

        public static void Cena_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox OCNtextBox = (TextBox)sender;

            int DotIndex = OCNtextBox.Text.LastIndexOf(',');

            int LastIndex = OCNtextBox.Text.Length;

            int Len = LastIndex - DotIndex;

            if (DotIndex > 0 && Len >= 3 && !char.IsControl(e.KeyChar)) { e.Handled = true; return; }

            num.CheckNumberDot(sender, e);

        }

        public static void Netto_TextChanged(object sender, EventArgs e, ref TextBox txtNetto, ref TextBox txtBrutto, ref TextBox txtVAT)
        {
            TextBox txtFocus = (TextBox)sender;

            if (txtFocus.Name == "txtNetto" && txtFocus.ContainsFocus) CalculateBrutto(ref txtNetto, ref txtBrutto, ref txtVAT);
            else if(txtFocus.Name == "txtBrutto" && txtFocus.ContainsFocus) CaluculateNetto(ref txtBrutto, ref txtNetto, ref txtVAT);
            else if (txtFocus.Name == "txtVAT" && txtFocus.ContainsFocus) 
            {
                //CalculateBrutto(ref txtNetto, ref txtBrutto, ref txtVAT);

                CaluculateNetto(ref txtBrutto, ref txtNetto, ref txtVAT);
            }

        }

        private static void CalculateBrutto(ref TextBox OCNtextBox, ref TextBox txtBrutto, ref TextBox txtVAT)
        {
            if (String.IsNullOrEmpty(txtVAT.Text)) { txtBrutto.Text = OCNtextBox.Text; return; }

            int last = OCNtextBox.Text.LastIndexOf(',') + 1;

            int len = OCNtextBox.Text.Length;

            if (last == len) return;

            float mng = 100 + int.Parse(txtVAT.Text);

            mng /= 100;

            float netto = float.Parse(OCNtextBox.Text);

            mng *= netto;

            mng = (float)Math.Round(mng, 2);

            //OCBtextBox.Text = mng.ToString();

            txtBrutto.Text = AddZero(mng.ToString());

        }

        private static void CaluculateNetto(ref TextBox OCBtextBox, ref TextBox txtNetto, ref TextBox txtVAT)
        {
            if (String.IsNullOrEmpty(txtVAT.Text)) { txtNetto.Text = OCBtextBox.Text; return; }

            int last = OCBtextBox.Text.LastIndexOf(',') + 1;

            int len = OCBtextBox.Text.Length;

            if (last == len) return;

            float mng = 100 + int.Parse(txtVAT.Text);

            mng /= 100;

            float brutto = float.Parse(OCBtextBox.Text);

            brutto /= mng;

            brutto = (float)Math.Round(brutto, 2);

            //OCNtextBox.Text = brutto.ToString();

            txtNetto.Text = AddZero(brutto.ToString());

        }

       


       

       
    }
}
