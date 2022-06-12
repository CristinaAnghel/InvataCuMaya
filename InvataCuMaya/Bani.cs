using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProiectInfoEducatie.ConturiDataSetTableAdapters;

namespace ProiectInfoEducatie
{
    internal class Bani
    {
        private int ID;
        private int bani;
        Bani(int Id)
        {
            ID = Id;
            ConturiTableAdapter cont = new ConturiTableAdapter();
            DataTable dataTable = cont.GetData();
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = String.Format("id = {0}", Id);
            bani = Convert.ToInt32(dataView[0]["Total"]);

        }

        private int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int Banii
        {
            get { return bani; }
            set { bani = value; }
        }
    }
}
