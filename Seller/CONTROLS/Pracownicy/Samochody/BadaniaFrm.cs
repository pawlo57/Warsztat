using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seller.Class;

namespace Seller.CONTROLS.Samochody
{
    public partial class BadaniaFrm : Form
    {
        #region PUBLIC

        public enum TYPE
        {
            QUICK,
            DETAIL,
            CANCEL
        }

        public TYPE RESULT = TYPE.QUICK;

        #endregion

        #region ACCESS

        public string DATA_OD { get { return DateHelp.GetDate(dtpDataOd.Value); } }

        public string DATA_DO { get { return DateHelp.GetDate(dtpDataDo.Value); } }

        #endregion

        public BadaniaFrm()
        {
            InitializeComponent();
        }

        private void cmdAnuluj_Click(object sender, EventArgs e)
        {
            RESULT = TYPE.CANCEL;

            Close();
        }

        private void cmdMonth_Click(object sender, EventArgs e)
        {
            RESULT = TYPE.QUICK;
            Close();
        }

        private void cmdSzukaj_Click(object sender, EventArgs e)
        {
            RESULT = TYPE.DETAIL;

            Close();
        }
    }
}
