using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pawel.Workshop.Utils.Key_Checker;

namespace Pawel.Workshop.Interfaces
{
    interface ICustomTextBoxChecker
    {
        bool isCheckValue { get; set; }

        bool checkValue();

        void setHighlitedState();

        void setNormalState();
    }
}
