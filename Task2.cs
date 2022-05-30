using System;

namespace Kek
{
    class Task2
    {
        private string template { get; set; }
        private double y1;//
        private double y2;//
        private double y3;//
        private double ally;//
        private double p1;//
        private double p2;//
        private double p3;//
        private double yp1;
        private double yp2;
        private double yp3;
        private double fullP;
        private double who;//
        private double Probability;

        public string GetAnsValue()
        {
            return Convert.ToString(Probability);
        }
        public string GetValue()
        {
            return template;
        }

        public Task2()
        {
            var rand = new Random();

            double y1 = 5 * rand.Next(2, 8);
            double y2 = 5 * rand.Next(2, 8);
            double y3 = 5 * rand.Next(2, 8);
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;

            double ally = y1 + y2 + y3;

            double yp1 = y1 / ally;
            double yp2 = y2 / ally;
            double yp3 = y2 / ally;
            this.yp1 = yp1;
            this.yp2 = yp2;
            this.yp3 = yp3;


            double p1 = 0.1 + 0.1 * rand.Next(1, 5);
            double p2 = 0.1 + 0.1 * rand.Next(1, 5);
            double p3 = 0.1 + 0.1 * rand.Next(1, 5);
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;

            double fullP = yp1 * p1 + yp2 * p2 + yp3 * p3;
            this.fullP = fullP;

            double PB = 0;
            byte who = Convert.ToByte(rand.Next(1, 4));
            switch (who)
            {
                case (1):
                    PB = yp1 * p1;
                    break;
                case (2):
                    PB = yp2 * p2;
                    break;
                case (3):
                    PB = yp3 * p3;
                    break;
            }
            Probability = Math.Round((PB) / fullP,2);
            string template;
            bool tackType = Convert.ToBoolean(rand.Next(0, 2));
            if (tackType)
                template = $"В корзине 3 сорта яблок: {y1} – первого, {y2} – второго и {y3} – третьего. Вероятности высокого содержания сахара в каждом из них соответственно равны {yp1}, {yp2}, {yp3}. Наудачу взятое яблоко оказалось с высоким содержанием сахара. Найти, вероятность того, что это яблоко {who} сорта";
            else
                template = $"Трое рабочих изготавливают однотипные изделия. Первый изготовил {y1} изделий, {y2} – второй и {y3} – третий. Вероятности брака у каждого рабочего соответственно равны {yp1}, {yp2}, {yp3}. Найти вероятность того, что наудачу взятая бракованная деталь изготовлена {who} рабочим.";
            this.template = template;
        }
    }
}
