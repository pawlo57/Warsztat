using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pawel.Workshop.Custom_controls.Custom_TextBox;
using Pawel.Workshop.Utils.Key_Checker;

namespace Pawel.Workshop.Custom_controls.Letter_TextBox
{
    class LetterTextBox : CustomTextBox
    {
        public LetterTextBox()
            : base()
        {
        }

        public override bool checkValueControl()
        {
            if (checkValue)
            {
                if (string.IsNullOrWhiteSpace(this.Text))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            e.Handled = KeyChecker.checkForLetterOrDigitKey(this.Text, e.KeyChar);
        }
    }
}
