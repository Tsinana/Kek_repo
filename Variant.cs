using System;
using System.Collections.Generic;
using System.Text;

namespace Kek
{
    public class Variant
    {
        private List<int> listQTN { get; set; }
        private int QuantityTask1 = -1;
        //private int QuantityTask2 = -1;
        //...
        //private int QuantityTask9 = -1;
        private List<Task1> ListTask1 { get; set; }
        //private List<Task2> ListTask2 { get; set; }
        //...
        //private List<Task9> ListTask9 { get; set; }

        public Variant(List<int> listQTN)
        {
            List<Task1> ListTask1 = new List<Task1>();

            this.listQTN = listQTN;
            int count1 = listQTN[0];
            for (int i = 0; i < count1; i++)
            {
                Task1 t = new Task1();
                ListTask1.Add(t);
            }
            this.ListTask1 = ListTask1;
            //ListTask2 = new List<Task2>();
            //...
            //ListTask9 = new List<Task9>();
        }
    }
}
