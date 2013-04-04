using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Pawel.Workshop.Interfaces;

namespace Pawel.Workshop.Custom_controls.Custom_TextBox
{
    abstract class CustomTextBox : TextBox, ICustomTextBoxChecker
    {
        public enum TextBoxType
        {
            Text,
            Number,
            TextAndNumber,
            NoText
        }

        public TextBoxType Type { get; set; }

        public bool isCheckValue { get; set; }

        public bool checkValue()
        {
            if (isCheckValue)
            {
                return checkValueControl();
            }

            return true;
        }

        protected abstract bool checkValueControl();

        public bool acceptKeys { get; set; }

        public void setHighlitedState()
        {
            this.BackColor = Color.Yellow;
        }

        public void setNormalState()
        {
            this.BackColor = Color.White;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            e.Handled = handleKeyPress(e);
        }

        private bool handleKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (acceptKeys)
            {
                return getProperKeyChecker(e);
            }

            return true;
        }

        protected abstract bool getProperKeyChecker(System.Windows.Forms.KeyPressEventArgs e);
    }
}
