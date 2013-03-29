using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Pawel.Workshop.Interfaces;
using Pawel.Workshop.Utils.Key_Checker;
using Pawel.Workshop.Custom_controls.Custom_TextBox;

namespace Pawel.Workshop.Custom_controls.Numeric_TextBox
{
    class NumericTextBox : CustomTextBox
    {
        public NumericTextBox() : base() { }

        public decimal value
        {
            get
            {
                decimal result = 0;
                decimal.TryParse(this.Text, out result);

                return result;
            }

            set { this.Text = value.ToString("0.00"); }
        }

        public override bool checkValueControl()
        {
            if (checkValue)
            {
                if (this.value < 0)
                {
                    this.setHighlitedState();
                    return false;
                }
            }

            this.setNormalState();

            return true;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            e.Handled = KeyChecker.checkForNumericKey(this.Text, e.KeyChar); 
        }

    }
}
