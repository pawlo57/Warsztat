using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pawel.Workshop.Update.Data_providers.Update_database;

namespace Pawel.Workshop.Update
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            UpdateDatabaseDataProvider.updateGoods();
        }
    }
}
