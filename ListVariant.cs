using System;
using System.Collections.Generic;
using System.Text;

namespace Kek
{
    class ListVariant
    {
        private int QuantityVariant = -1;
        private List<int> listQTN { get; set; }
        private List<Variant> ListVar { get; set; }
        public ListVariant(int QuantityVariant, List<int> listQTN)
        {
            this.QuantityVariant = QuantityVariant;
            this.listQTN = listQTN;
            List<Variant> ListVar = new List<Variant>();
            for (int i = 0; i < QuantityVariant; i++)
            {
                Variant t = new Variant(listQTN);
                ListVar.Add(t);
            }
            this.ListVar = ListVar;
        }
    }
}
