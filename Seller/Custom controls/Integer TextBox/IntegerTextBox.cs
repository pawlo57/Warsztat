﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pawel.Workshop.Custom_controls.Custom_TextBox;
using Pawel.Workshop.Utils.Key_Checker;

namespace Pawel.Workshop.Custom_controls.Integer_TextBox
{
    class IntegerTextBox : CustomTextBox
    {
        public IntegerTextBox()
            : base()
        {
        }

        public int value
        {
            get
            {
                int result = 0;
                int.TryParse(this.Text, out result);

                return result;
            }

            set { this.Text = value.ToString(); }
        }

        protected override bool checkValueControl()
        {
            if (isCheckValue)
            {
                if (value > 0) return true;
            }

            return false;
        }

        protected override bool getProperKeyChecker(System.Windows.Forms.KeyPressEventArgs e)
        {
            return KeyChecker.checkForIntegerKey(this.Text, e.KeyChar);
        }
    }
}
