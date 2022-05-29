using System;
using System.Collections.Generic;
using System.Text;

namespace Kek
{
    class Task5
    {
        private string template { get; set; }//print
        private int n;//
        private double p;//
        private double q;
        private double mX;//answer
        private double dX;//answer
        private int[] arrX;//answer
        private double[] arrP;//answer

        public string GetValue()
        {
            return template;
        }

        public Task5()
        {
            var rand = new Random();

            int n = rand.Next(3, 5);
            this.n = n;

            double p = 0.1 + 0.1 * rand.Next(1, 4);
            this.p = p;
            q = 1 - p;

            int[] arrX = new int[n];
            double[] arrP = new double[n];

            for (int i = 0; i < n; i++)
            {
                arrX[i] = i;
                arrP[i] = Sochet(n,i)*Math.Pow(p,i)* Math.Pow(p, n-i);
            }
            double mX = n * p;
            double dX = n * p * q;
            bool tackType = Convert.ToBoolean(rand.Next(0, 2));
            if (tackType)
                template = $"Имеются {n} базы с независимым снабжением. Вероятность отсутствия на базе нужного товара равна {p}. Предприниматель решил закупить некий товар. Составить закон распределения числа баз, на которых в данный момент этот товар отсутствует. Вычислить математическое ожидание и дисперсию этой случайной величины. ";
            else
                template = $"Студент купил {n} билета новогодней лотереи. Вероятность выигрыша по одному билету равна {p}. Составить закон распределения, вычислить математическое ожидание и дисперсию числа выигрышей среди купленных билетов.";
            template = template;
            this.arrX = arrX;
            this.arrP = arrP;
        }

        private long Factorial(int a)
        {
            long result;
            if (a == 0) return 1;
            else
            {
                result = a * Factorial(a - 1);
                return result;
            }
        }

        private double Sochet(int a, int b)
        {
            return Factorial(a) / (Factorial(a - b) * Factorial(b));
        }
    }
}
