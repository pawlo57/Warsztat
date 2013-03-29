using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pawel.Workshop.Utils.Key_Checker
{
    static class KeyChecker
    {
        public static bool checkForNumericKey(string text, char keyChar)
        {
            if (!char.IsDigit(keyChar) && !checkForControlOrDot(keyChar))
            {
                return true;
            }
            else
            {
                return checkCurrentDotLength(text, keyChar);
            }
        }

        public static bool checkForIntegerKey(string text, char keyChar)
        {
            if (!char.IsDigit(keyChar) && !char.IsControl(keyChar))
            {
                return true;
            }
            else
            {
                return checkCurrentLength(text, keyChar);
            }
        }

        public static bool checkForLetterOrDigitKey(string text, char keyChar)
        {
            return (!char.IsLetterOrDigit(keyChar) && !checkForControlOrPunctation(keyChar));
        }


        private static bool checkForControlOrPunctation(char keyChar)
        {
            return (char.IsControl(keyChar) || char.IsPunctuation(keyChar));
        }

        private static bool checkForControlOrDot(char keyChar)
        {
            return char.IsControl(keyChar) || (keyChar.Equals(','));
        }

        private static bool checkCurrentDotLength(string text, char keychar)
        {
            if (char.IsControl(keychar))
            {
                return false;
            }

            int dotIndex = text.IndexOf(',');
            if (dotIndex > 0 && keychar.Equals(','))
            {
                return true;
            }
            if (dotIndex > 0)
            {
                return text.Length - dotIndex > 2; ;
            }

            return false;
        }

        private static bool checkCurrentLength(string text, char keyChar)
        {
            if (char.IsControl(keyChar))
            {
                return false;
            }

            return text.Length >= 2;
        }
    }
}
