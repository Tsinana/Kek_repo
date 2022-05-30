using System;


namespace Kek
{
    class Tast3
    {
        private string template { get; set; }
        private bool Bilet;
        private int n;
        private int k;
        private double P;
        private double p;
        private double q;

        public string GetValue()
        {
            return template;
        }
        public string GetAnsValue()
        {
            return Convert.ToString(P);
        }

        public Tast3(int a)
        {
            var rand = new Random();
            bool Bilet;
            if (a % 2 == 0)
            {
                Bilet = false;
            }
            else Bilet = true;
            this.Bilet = Bilet;
            int n = rand.Next(3, 6);
            this.n = n;
            int k = n - rand.Next(1, n);
            this.k = k;
            double p;
            do
                p = Math.Round(rand.NextDouble(), 1);
            while (p == 0 || p == 1);
                this.p = p;
            double q = 1 - p;
            this.q = q;
            double P = 0;
            this.P = P;
            if (Bilet == false)
            {
                for (int i = k; i < n; i++)
                {
                    P += Sochet(n, i) * Math.Pow(p, i) * Math.Pow(q, (n - i));
                }
            }
            else
            {
                P += Sochet(n, k) * Math.Pow(p, k) * Math.Pow(q, (n - k));
            }
            this.P = Math.Round(P, 4);
            if (Bilet == true)
                template = $"Вероятность выиграть по лотерейному билету равна {p} . Найти вероятность выиграть по {k} билетам из {n}.";
            else
                template = $"Событие В произойдет в случае, если событие А наступит не менее {k} раз. Найти вероятность наступления события B, если будет произведено {n} независимых испытаний, в каждом из которых вероятность наступления события А равна {p}.";
            this.template = template;
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
        private long Sochet(int a, int b)
        {
            return Factorial(a) / (Factorial(a - b) * Factorial(b));
        }
    }
}
