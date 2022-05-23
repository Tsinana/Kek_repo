using System;
using System.Collections.Generic;
using System.Text;

namespace Kek
{
    public class Variant
    {
        private List<int> listQTN { get; set; }
        private int QuantityTask1 = -1;
        private int QuantityTast3 = -1;
        private int QuantityTask4 = -1;
        //...
        //private int QuantityTask9 = -1;
        private List<Task1> ListTask1 { get; set; }
        private List<Tast3> ListTast3 { get; set; }
        private List<Task4> ListTask4 { get; set; }
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
            List<Tast3> ListTast3 = new List<Tast3>();

            this.listQTN = listQTN;
            int count3 = listQTN[2];
            for (int i = 0; i < count3; i++)
            {
                Tast3 t = new Tast3(i);
                ListTast3.Add(t);
            }
            this.ListTast3 = ListTast3;

            List<Task4> ListTask4 = new List<Task4>();
            this.listQTN = listQTN;
            int count4 = listQTN[3];
            for (int i = 0; i < count1; i++)
            {
                Task4 t = new Task4();
                ListTask4.Add(t);
            }
            this.ListTask4 = ListTask4;
            //ListTask2 = new List<Task2>();
            //...
            //ListTask9 = new List<Task9>();
        }
    }
}
