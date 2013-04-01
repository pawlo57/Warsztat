using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Pawel.Workshop.Interfaces;

namespace Pawel.Workshop.Custom_controls.Custom_ComboBox
{
    class CustomComboBox : ComboBox, ICustomTextBoxChecker
    {
        public bool isCheckValue { get; set; }

        public int value
        {
            get
            {
                return SelectedValue == null ? -1 : (int)this.SelectedValue;
            }
            set { this.SelectedValue = value; }
        }

        public bool checkValue()
        {
            if (isCheckValue)
            {
                if (value < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return true;
        }

        public void setHighlitedState()
        {
            this.BackColor = Color.Yellow;
        }

        public void setNormalState()
        {
            this.BackColor = Color.White;
        }

       // private string classType

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }
    }
}
