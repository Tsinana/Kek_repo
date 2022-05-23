using System;
using System.Collections.Generic;
using System.Text;

namespace Kek
{
    public class Variant
    {
        private int QuantityTask1 = -1;
        //private int QuantityTask2 = -1;
        private List<Task1> ListTask1 { get; set; }
        //private List<Task2> ListTask2 { get; set; }

        public Variant()
        {
            ListTask1 = new List<Task1>();
            //ListTask2 = new List<Task2>();
            //...
            //ListTask9 = new List<Task9>();
        }
        public void AddTask1()
        {
            Task1 t = new Task1();
            ListTask1.Add(t);
            QuantityTask1++;
        }
        /*public void AddTask2()
        {
            Task2 t = new Task2();
            ListTask2.Add(t);
            QuantityTask2++;
        }
        */

    }
}
