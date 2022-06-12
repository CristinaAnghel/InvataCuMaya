using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProiectInfoEducatie.ConturiDataSetTableAdapters;

namespace ProiectInfoEducatie
{
    internal class Haina
    {
        private int ID;
        private int haina;
        Haina(int Id)
        {
            ID = Id;
            ConturiTableAdapter cont = new ConturiTableAdapter();
            DataTable dataTable = cont.GetData();
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = String.Format("id = {0}", Id);
            haina = Convert.ToInt32(dataView[0]["Haina"]);

        }

        private int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int Hainaa
        {
            get { return haina; }
            set { haina = value; }
        }
    }
}
