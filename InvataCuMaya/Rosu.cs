using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProiectInfoEducatie.ConturiDataSetTableAdapters;

namespace ProiectInfoEducatie
{
    internal class Rosu
    {
        private int ID;
        private int rosu;
        Rosu(int Id)
        {
            ID = Id;
            ConturiTableAdapter cont = new ConturiTableAdapter();
            DataTable dataTable = cont.GetData();
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = String.Format("id = {0}", Id);
            rosu = Convert.ToInt32(dataView[0]["areRosu"]);

        }

        private int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int Rosuu
        {
            get { return rosu; }
            set { rosu = value; }
        }
    }
}
