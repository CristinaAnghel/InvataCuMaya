using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProiectInfoEducatie.ConturiDataSetTableAdapters;

namespace ProiectInfoEducatie
{
    internal class Albastru
    {
        private int ID;
        private int albastru;
        Albastru(int Id)
        {
            ID = Id;
            ConturiTableAdapter cont = new ConturiTableAdapter();
            DataTable dataTable = cont.GetData();
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = String.Format("id = {0}", Id);
            albastru = Convert.ToInt32(dataView[0]["areAlbastru"]);

        }

        private int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int Albastruu
        {
            get { return albastru; }
            set { albastru = value; }
        }
    }
}
