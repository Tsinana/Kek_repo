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
        private double probability;

        public Task1()
        {
            var rand = new Random();
            int quBB = rand.Next(4, 12);
            this.quantityBlackBalls = quBB;
            int quWB = rand.Next(4, 12);
            this.quantityWhiteBalls = quWB;
            int quAll = quBB + quWB;
            this.quantityAllBalls = quAll;
            int quT = rand.Next(2, (quAll / 2));
            this.quantityTakeBalls = quT;
            int ofThem = rand.Next(1, (quT - 1));
            this.ofThem = ofThem;
            bool isWhite = Convert.ToBoolean(rand.Next(0, 1));
            this.isWhite = isWhite;
            double prob;
            if (isWhite)
                //prob = Sochet(quWB, ofThem) * Sochet(quBB, quT - ofThem) / (Sochet(quAll, quT));
                prob = Sochet(10, 3) * Sochet(5, 0) / (Sochet(15, 3));
            else
                //prob = Sochet(quBB, ofThem) * Sochet(quWB, quT - ofThem) / (Sochet(quAll, quT));
                prob = Sochet(10, 3) * Sochet(5, 0) / (Sochet(2, 1));
            this.probability = Math.Round(prob, 4);

            bool is1type = Convert.ToBoolean(rand.Next(0, 1));
            string template;
            string color = "";
            if (is1type)
            {
                if (isWhite)
                    color = "белыми";
                else
                    color = "черными";
                template = $"В урне {quWB} белых и {quBB} черных шаров. Из урны вынимают сразу {quT} шаров. Найти вероятность того, что {ofThem} из них будут {color}.";
            }
            else
                if (isWhite)
                template = $"В группе {quAll} человек, {quWB} из которых успевающие. По списку вызывают сразу {quT} человек. Найти вероятность того, что {ofThem} из них будут успевающими.";
            else
                template = $"В группе {quAll} человек, {quBB} из которых неуспевающие. По списку вызывают сразу {quT} человек. Найти вероятность того, что {ofThem} из них будут неуспевающими.";
            this.template = template;
        }

        private int Factorial(int a)
        {
            int result;
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
