using System;
using System.Collections.Generic;
using System.Text;

namespace Kek
{
    class Task2
    {
        private string template { get; set; }
        private int y1;//
        private int y2;//
        private int y3;//
        private int ally;//
        private double p1;//
        private double p2;//
        private double p3;//
        private double yp1;
        private double yp2;
        private double yp3;
        private double fullP;
        private double who;//
        private double Probability;
        public Task2()
        {
            var rand = new Random();

            int y1 = 5 * rand.Next(2, 8);
            int y2 = 5 * rand.Next(2, 8);
            int y3 = 5 * rand.Next(2, 8);
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;

            int ally = y1 + y2 + y3;

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
            double Probability = Math.Round((PB) / fullP,2);
            string template;
            bool tackType = Convert.ToBoolean(rand.Next(0, 2));
            if (tackType)
                template = $"В корзине 3 сорта яблок: {y1} – первого, {y2} – второго и {y3} – третьего. Вероятности высокого содержания сахара в каждом из них соответственно равны {yp1}, {yp2}, {yp3}.Наудачу взятое яблоко оказалось с высоким содержанием сахара.Найти, вероятность того, что это яблоко {who} сорта";
            else
                template = $"Трое рабочих изготавливают однотипные изделия. Первый изготовил {y1} изделий, {y2} – второй и {y3} – третий. Вероятности брака у каждого рабочего соответственно равны {yp1}, {yp2}, {yp3}. Найти вероятность того, что наудачу взятая бракованная деталь изготовлена {who} рабочим.";
            this.template = template;
        }
    }
}
