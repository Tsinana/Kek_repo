using System.Collections.Generic;

namespace Kek
{
    public class Variant
    {
        private string name { get; set; }
        private List<int> listQTN { get; set; }
        private List<Task1> ListTask1 { get; set; }
        private List<Task2> ListTask2 { get; set; }
        private List<Tast3> ListTast3 { get; set; }
        private List<Task4> ListTask4 { get; set; }
        private List<Task5> ListTask5 { get; set; }
        private List<Task6> ListTask6 { get; set; } 
        private List<Task7> ListTask7 { get; set; }
        private List<Task8> ListTask8 { get; set; }
        private List<Task9> ListTask9 { get; set; }

        public Variant(List<int> listQTN,string name)
        {
            this.name = name;
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
            int count3 = listQTN[2];
            for (int i = 0; i < count3; i++)
            {
                Tast3 t = new Tast3(i);
                ListTast3.Add(t);
            }
            this.ListTast3 = ListTast3;

            List<Task4> ListTask4 = new List<Task4>();
            int count4 = listQTN[3];
            for (int i = 0; i < count4; i++)
            {
                Task4 t = new Task4();
                ListTask4.Add(t);
            }
            this.ListTask4 = ListTask4;
          
            List<Task5> ListTask5 = new List<Task5>();
            int count5 = listQTN[4];
            for (int i = 0; i < count5; i++)
            {
                Task5 t = new Task5();
                ListTask5.Add(t);
            }
            this.ListTask5 = ListTask5;

            List<Task6> ListTask6 = new List<Task6>();
            int count6 = listQTN[5];
            for (int i = 0; i < count6; i++)
            {
                Task6 t = new Task6();
                ListTask6.Add(t);
            }
            this.ListTask6 = ListTask6;

            List<Task7> ListTask7 = new List<Task7>();
            int count7 = listQTN[6];
            for (int i = 0; i < count7; i++)
            {
                Task7 t = new Task7();
                ListTask7.Add(t);
            }
            this.ListTask7 = ListTask7;

            List<Task8> ListTask8 = new List<Task8>();
            int count8 = listQTN[7];
            for (int i = 0; i < count8; i++)
            {
                Task8 t = new Task8();
                ListTask8.Add(t);
            }
            this.ListTask8 = ListTask8;

            List<Task9> ListTask9 = new List<Task9>();
            int count9 = listQTN[8];
            for (int i = 0; i < count9; i++)
            {
                Task9 t = new Task9();
                ListTask9.Add(t);
            }
            this.ListTask9 = ListTask9;
        }

        public string GetName()
        {
            return name;
        }


        public List<string> GetAnsValue()
        {
            List<string> listStr = new List<string>();


            foreach (Task1 a in ListTask1)
            {
                string ans = a.GetAnsValue();
                listStr.Add(ans);
            }

            //...


            return listStr;
        }

        public string GetValue()
        {
            string value = "Вариант " + name + "\n\n";
            int idx = 1;

            foreach (Task1 a in ListTask1)
            {
                value = value + "          " + idx+". " +a.GetValue() + "\n\n";
                idx++;
            }

            foreach (Task2 a in ListTask2)
            {
                value = value + "          " + idx + ". " + a.GetValue() + "\n\n";
                idx++;
            }

            foreach (Tast3 a in ListTast3)
            {
                value = value + "          " + idx + ". " + a.GetValue() + "\n\n";
                idx++;
            }

            foreach (Task4 a in ListTask4)
            {
                value = value + "          " + idx + ". " + a.GetValue() + "\n\n";
                idx++;
            }

            foreach (Task5 a in ListTask5)
            {
                value = value + "          " + idx + ". " + a.GetValue() + "\n\n";
                idx++;
            }

            foreach (Task6 a in ListTask6)
            {
                value = value + "          " + idx + ". " + a.GetValue() + "\n\n";
                idx++;
            }

            foreach (Task7 a in ListTask7)
            {
                value = value + "          " + idx + ". " + a.GetValue() + "\n\n";
                idx++;
            }

            foreach (Task8 a in ListTask8)
            {
                value = value + "          " +idx + ". " + a.GetValue() + "\n\n";
                idx++;
            }
            /*
            foreach (Task9 a in ListTask9)
            {
                value = value + "          " +idx + ". " + a.GetValue() + "\n\n";
                idx++;
            }
            */
            return value;
        }
    }
}
