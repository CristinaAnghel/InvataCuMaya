using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProiectInfoEducatie.ConturiDataSetTableAdapters;

namespace ProiectInfoEducatie
{
    internal class Par
    {
        private int ID;
        private int par;
        Par(int Id)
        {
            ID = Id;
            ConturiTableAdapter cont = new ConturiTableAdapter();
            DataTable dataTable = cont.GetData();
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = String.Format("id = {0}", Id);
            par = Convert.ToInt32(dataView[0]["Par"]);

        }

        private int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int Parr
        {
            get { return par; }
            set { par = value; }
        }
    }
}
