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

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }
      
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics g = e.Graphics;

            g.DrawString("test", new Font("Times New Roman", 12), Brushes.Aqua, 0, 0);

            g.FillRectangle(Brushes.Coral, 0, 0, 100, 100);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

           // DropDownItem item = (DropDownItem)Items[e.Index];
            // Draw the colored 16 x 16 square
           // e.Graphics.DrawImage(item.Image, e.Bounds.Left, e.Bounds.Top);
            // Draw the value (in this case, the color name)
            e.Graphics.DrawString("))", e.Font, new
                    SolidBrush(e.ForeColor), e.Bounds.Left + 20, e.Bounds.Top + 2);

            //base.OnDrawItem(e);
        }
    }
}
