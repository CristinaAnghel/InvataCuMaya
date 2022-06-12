using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProiectInfoEducatie.ConturiDataSetTableAdapters;

namespace ProiectInfoEducatie
{
    internal class Salopeta
    {
        private int ID;
        private int salopeta;
        Salopeta(int Id)
        {
            ID = Id;
            ConturiTableAdapter cont = new ConturiTableAdapter();
            DataTable dataTable = cont.GetData();
            DataView dataView = dataTable.DefaultView;

            dataView.RowFilter = String.Format("id = {0}", Id);
            salopeta = Convert.ToInt32(dataView[0]["areSalopeta"]);

        }

        private int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int Salopetaa
        {
            get { return salopeta; }
            set { salopeta = value; }
        }

    }
}
