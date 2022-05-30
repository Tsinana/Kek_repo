using System;

namespace Kek
{
    class Task4
    {
        private string template { get; set; }
        private double x;
        private double npq;
        private double xLap1;
        private double xLap2;
        private double lev;
        private double prav;


        public string GetValue()
        {
            return template;
        }

        public Task4()
        {
            var rand = new Random();
            int n = rand.Next(150, 201);
            int k = rand.Next(2, 6);
            int kk = 150 + rand.Next(15, 36);
            double p;
            do
                 p = Math.Round(rand.NextDouble(), 2);
            while (p == 0.0);
            double q = 1 - p;
            double x = (k - (n * p)) / (Math.Sqrt(n * p * q));
            this.x = x;
            int k1 = kk + 1;
            int k2 = n;
            double npq = Math.Sqrt(n * p * q);
            this.npq = npq;
            double xLap1 = Math.Round((k1 - (n * p)) / (Math.Sqrt(n * p * q)),2);
            double xLap2 = Math.Round((k2 - (n * p)) / (Math.Sqrt(n * p * q)), 2);
            this.xLap1 = xLap1;
            this.xLap2 = xLap2;
            double lev = n * p - q;
            double prav = n * p + p;
            this.lev = lev;
            this.prav = prav;
            string template;
            bool tackType = Convert.ToBoolean(rand.Next(0, 2));
            if (tackType)
                template = $"Станок – автомат штампует детали. Вероятность того, что изготовленная деталь имеет дефект равна {p}. Найти вероятность того, что среди {n} деталей окажется: а) {k} бракованных; б) более {k} не бракованных. Найти наиболее вероятное число бракованных деталей.";
            else
                template = $"На станциях отправления поездов находится {n} автоматов для продажи билетов. Вероятность выхода из строя одного автомата в течение часа равна {p}. Найти вероятность того, что в течение часа выйдут из строя: а) {k} автоматов(a); б) от {k1} до {k2} автоматов. Найти наиболее вероятное число вышедших из строя автоматов.";
            this.template = template;
            //Значение функций считать по таблице ептаааа//
        }
        public string GetAnsValue()
        {
            char fis = Convert.ToChar(966);
            char Fi = Convert.ToChar(934);
            char men = Convert.ToChar(60);
            return Convert.ToString($"a) P(k) = {fis}({x})/{npq}   б){Fi}({xLap2})={Fi}({xLap1}) в){lev}{men}=k{men}{prav}");
        }
    }
}
