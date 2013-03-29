﻿using System;
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
        public bool checkValue { get; set; }

        public abstract bool checkValueControl();

        public void setHighlitedState()
        {
            this.BackColor = Color.Yellow;
        }

        public void setNormalState()
        {
            this.BackColor = Color.White;
        }
    }
}