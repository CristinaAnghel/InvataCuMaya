using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProiectInfoEducatie.ConturiDataSetTableAdapters;

namespace ProiectInfoEducatie
{
    internal class Galben
    {
        private int ID;
        private int galben;
        Galben(int Id)
        {
            ID = Id;
            ConturiTableAdapter cont = new ConturiTableAdapter();
            DataTable dataTable = cont.GetData();
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = String.Format("id = {0}", Id);
            galben = Convert.ToInt32(dataView[0]["areGalben"]);

        }

        private int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int Galbenn
        {
            get { return galben; }
            set { galben = value; }
        }
    }
}
