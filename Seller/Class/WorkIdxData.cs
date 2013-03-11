using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seller.Class
{
    public static class WorkIdxData
    {
        public static List<WorkIdx> workIndex = new List<WorkIdx>{
                new WorkIdx { ID = WorkIdx.TYPE.SELECT, JEDNOSTKA_CZASU = "Wybierz" },
                new WorkIdx { ID = WorkIdx.TYPE.MINUTA, JEDNOSTKA_CZASU = "Minuta" },
                new WorkIdx { ID = WorkIdx.TYPE.GODZINA, JEDNOSTKA_CZASU = "Godzina" },
                new WorkIdx { ID = WorkIdx.TYPE.DZIEN, JEDNOSTKA_CZASU = "Dzień" },
                new WorkIdx { ID = WorkIdx.TYPE.MIESIAC, JEDNOSTKA_CZASU = "Miesiąc" }};

        public static void LoadWorkIndex(ref ComboBox cbx)
        {
            cbx.DataSource = workIndex;

            cbx.DisplayMember = "JEDNOSTKA_CZASU";
            cbx.ValueMember = "ID";
        }
    }
}
