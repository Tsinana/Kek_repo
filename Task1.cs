using System;
using System.Collections.Generic;
using System.Text;

namespace Kek
{
    public class Task1
    {
        private string template;
        private int quantityBlackBalls;//
        private int quantityWhiteBalls;//
        private int quantityAllBalls;
        private int quantityTakeBalls;//
        private int ofThem;//
        private bool isWhite;//
        private double probabilityability;

        public Task1()
        {
            var rand = new Random();

            bool isWhite = Convert.ToBoolean(rand.Next(0, 2));
            this.isWhite = isWhite;
            int quantityAllBalls = rand.Next(9, 25);
            this.quantityAllBalls = quantityAllBalls;
            int quantityWhiteBalls = rand.Next(4, quantityAllBalls - 4);
            this.quantityWhiteBalls = quantityWhiteBalls;
            this.quantityBlackBalls = quantityAllBalls- quantityWhiteBalls;

            int quantityTakeBalls = rand.Next(4, quantityAllBalls);//Всего взяли
            this.quantityTakeBalls = quantityTakeBalls;

            int ofThem;//Из них
            if (isWhite)
                ofThem = rand.Next(4, quantityTakeBalls);
            else
                ofThem = rand.Next(4, quantityTakeBalls);
            this.ofThem = ofThem;

            double probability;
            if (isWhite)
                probability = Sochet(quantityWhiteBalls, ofThem) * Sochet(quantityBlackBalls, quantityTakeBalls - ofThem) / (Sochet(quantityAllBalls, quantityTakeBalls));
            else
                probability = Sochet(quantityBlackBalls, ofThem) * Sochet(quantityWhiteBalls, quantityTakeBalls - ofThem) / (Sochet(quantityAllBalls, quantityTakeBalls));
            this.probabilityability = Math.Round(probability, 4);

            bool is1type = Convert.ToBoolean(rand.Next(0, 2));
            string template;
            string color = "";
            if (is1type)
            {
                if (isWhite)
                    color = "белыми";
                else
                    color = "черными";
                template = $"В урне {quantityWhiteBalls} белых и {quantityBlackBalls} черных шаров. Из урны вынимают сразу {quantityTakeBalls} шаров. Найти вероятность того, что {ofThem} из них будут {color}.";
            }
            else
                if (isWhite)
                template = $"В группе {quantityAllBalls} человек, {quantityWhiteBalls} из которых успевающие. По списку вызывают сразу {quantityTakeBalls} человек. Найти вероятность того, что {ofThem} из них будут успевающими.";
            else
                template = $"В группе {quantityAllBalls} человек, {quantityBlackBalls} из которых неуспевающие. По списку вызывают сразу {quantityTakeBalls} человек. Найти вероятность того, что {ofThem} из них будут неуспевающими.";
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
