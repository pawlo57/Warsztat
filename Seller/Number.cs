using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Seller
{
    class Number
    {
        //Int32 n;
        //String znak;

        public Number()
        {
          //  n = 0;
            //znak = "";
        }

        private bool IsNumber(KeyPressEventArgs e)
        {

            if ((e.KeyChar >= '0'  && e.KeyChar <= '9') || e.KeyChar == 8 ||
                char.IsControl(e.KeyChar) || e.KeyChar == '-')  return true; 
                  
       
            return false;
        }

        private bool IsLetter(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') ||
                (e.KeyChar >= 'A' && e.KeyChar <= 'Z') ||
                e.KeyChar == 8 ||
                e.KeyChar == 'Ą' || e.KeyChar == 'ą' ||
                e.KeyChar == 'Ć' || e.KeyChar == 'ć' ||
                e.KeyChar == 'Ę' || e.KeyChar == 'ę' ||
                e.KeyChar == 'Ł' || e.KeyChar == 'ł' ||
                e.KeyChar == 'Ń' || e.KeyChar == 'ń' ||
                e.KeyChar == 'Ó' || e.KeyChar == 'ó' ||
                e.KeyChar == 'Ś' || e.KeyChar == 'ś' ||
                e.KeyChar == 'Ź' || e.KeyChar == 'ź' ||
                e.KeyChar == 'Ż' || e.KeyChar == 'ż' ||
                e.KeyChar == '(' || e.KeyChar == ')' ||
                e.KeyChar == '_' || e.KeyChar == '.' ||
                e.KeyChar == ',') return true;


            return false;
        }

        private bool IsDot(KeyPressEventArgs e)
        {
            if (e.KeyChar == ',') return true;
            else return false;
        }

        private bool IsHash(KeyPressEventArgs e)
        {
            if (e.KeyChar == '/') return true;
            else return false;
        }

        private bool IsMinus(KeyPressEventArgs e)
        {
            if (e.KeyChar == '-') return true;
            else return false;
        }

        private bool IsSpace(KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') return true;
            else return false;
        }

        public void CheckNumber(object sender, KeyPressEventArgs e)
        {
            if (IsNumber(e) == true) e.Handled = false;
            else e.Handled = true;
        }

        public void CheckLetter(object sender, KeyPressEventArgs e)
        {
            if (IsLetter(e) == true || IsSpace(e) == true || IsDot(e) == true) e.Handled = false;
            else e.Handled = true;
        }

        public void CheckNumberLetter(object sender, KeyPressEventArgs e)
        {
            if (IsNumber(e) == true || IsLetter(e) == true || IsSpace(e) == true || IsDot(e) == true) e.Handled = false;
            else e.Handled = true;
        }

        public void CheckNumberDot(object sender, KeyPressEventArgs e)
        {
            if (IsNumber(e) == true || IsDot(e) == true) e.Handled = false;
            else e.Handled = true;
        }

        public void CheckNumberLetterHash(object sender, KeyPressEventArgs e)
        {
            if(IsNumber(e) == true || IsLetter(e) == true || IsHash(e) == true || IsMinus(e) == true ||
                IsSpace(e) == true) e.Handled = false;
            else e.Handled = true;
        }

        public void CheckDate(object sender, KeyPressEventArgs e)
        {
            if (IsNumber(e) == true || IsMinus(e) == true) e.Handled = false;
            else e.Handled = true;
        }





       
    }
}
