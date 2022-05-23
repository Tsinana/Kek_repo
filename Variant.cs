using System;
using System.Collections.Generic;
using System.Text;

namespace Kek
{
    public class Variant
    {
        private List<int> listQTN { get; set; }
      
        private int QuantityTask1 = -1;
        private int QuantityTask2 = -1;
        private int QuantityTast3 = -1;
        private int QuantityTast5 = -1;

        private List<Task1> ListTask1 { get; set; }
        private List<Task2> ListTask2 { get; set; }
        private List<Tast3> ListTast3 { get; set; }
        private List<Task5> ListTask5 { get; set; }

        public Variant(List<int> listQTN)
        {
            this.listQTN = listQTN;

            List<Task1> ListTask1 = new List<Task1>();
            int count1 = listQTN[0];
            for (int i = 0; i < count1; i++)
            {
                Task1 t = new Task1();
                ListTask1.Add(t);
            }
            this.ListTask1 = ListTask1;

            List<Task2> ListTask2 = new List<Task2>();
            int count2 = listQTN[1];
            for (int i = 0; i < count2; i++)
            {
                Task2 t = new Task2();
                ListTask2.Add(t);
            }
            this.ListTask2 = ListTask2;

            List<Tast3> ListTast3 = new List<Tast3>();
            this.listQTN = listQTN;
            int count3 = listQTN[2];
            for (int i = 0; i < count3; i++)
            {
                Tast3 t = new Tast3(i);
                ListTast3.Add(t);
            }
            this.ListTast3 = ListTast3;

            List<Task5> ListTask5 = new List<Task5>();
            this.listQTN = listQTN;
            int count5 = listQTN[4];
            for (int i = 0; i < count5; i++)
            {
                Task5 t = new Task5();
                ListTask5.Add(t);
            }
            this.ListTask5 = ListTask5;

        }
    }
}
