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
        private List<string> listQTNVarName { get; set; }

        public ListVariant(int QuantityVariant, List<int> listQTN, List<string> listQTNVarName)
        {
            this.QuantityVariant = QuantityVariant;
            this.listQTN = listQTN;
            this.listQTNVarName = listQTNVarName;
            List<Variant> ListVar = new List<Variant>();
            for (int i = 0; i < QuantityVariant; i++)
            {
                string name = listQTNVarName[i];
                Variant t = new Variant(listQTN,name);
                ListVar.Add(t);
            }
            this.ListVar = ListVar;
        }

        public List<Variant> GetListVar()
        {
            return ListVar;
        }
    }
}
