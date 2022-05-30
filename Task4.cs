using System;

namespace Kek
{
    class Task4
    {
        private string template { get; set; }

        public string GetAnsValue()
        {
            return "";//Convert.ToString(xLap1);
        }

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
            double p = Math.Round(rand.NextDouble(),2);
            double q = 1 - p;
            double x = (k - (n * p)) / (Math.Sqrt(n * p * q));
            int k1 = kk + 1;
            int k2 = n;
            double xLap1 = Math.Round((k1 - (n * p)) / (Math.Sqrt(n * p * q)),2);
            double xLap2 = Math.Round((k2 - (n * p)) / (Math.Sqrt(n * p * q)), 2);
            string template;
            bool tackType = Convert.ToBoolean(rand.Next(0, 2));
            if (tackType)
                template = $"Станок – автомат штампует детали. Вероятность того, что изготовленная деталь имеет дефект равна {p}. Найти вероятность того, что среди {n} деталей окажется: а) {k} бракованных; б) более {k} не бракованных. Найти наиболее вероятное число бракованных деталей.";
            else
                template = $"На станциях отправления поездов находится {n} автоматов для продажи билетов. Вероятность выхода из строя одного автомата в течение часа равна {p}. Найти вероятность того, что в течение часа выйдут из строя: а) {k} автоматов(a); б) от {k1} до {k2} автоматов. Найти наиболее вероятное число вышедших из строя автоматов.";
            this.template = template;
            //Значение функций считать по таблице ептаааа//
        }
    }
}
