using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProiectInfoEducatie.ConturiDataSetTableAdapters;

namespace ProiectInfoEducatie
{
    internal class Maro
    {
        private int ID;
        private int maro;
        Maro(int Id)
        {
            ID = Id;
            ConturiTableAdapter cont = new ConturiTableAdapter();
            DataTable dataTable = cont.GetData();
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = String.Format("id = {0}", Id);
            maro = Convert.ToInt32(dataView[0]["areMaro"]);

        }

        private int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int Maroo
        {
            get { return maro; }
            set { maro = value; }
        }

    }
}
