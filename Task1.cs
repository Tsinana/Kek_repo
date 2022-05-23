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
            bool isWhite = Convert.ToBoolean(rand.Next(0, 2));
            this.isWhite = isWhite;
            int quBB = rand.Next(4, 11);
            this.quantityBlackBalls = quBB;
            int quWB = rand.Next(4, 11);
            this.quantityWhiteBalls = quWB;
            int quAll = quBB + quWB;
            this.quantityAllBalls = quAll;
            int quT = rand.Next(2, (quAll / 2)+1);
            this.quantityTakeBalls = quT;
            int ofThem = rand.Next(1, quT);
            this.ofThem = ofThem;
            double prob;
            if (isWhite)
                prob = Sochet(quWB, ofThem) * Sochet(quBB, quT - ofThem) / (Sochet(quAll, quT));
            else
                prob = Sochet(quBB, ofThem) * Sochet(quWB, quT - ofThem) / (Sochet(quAll, quT));
            this.probability = Math.Round(prob, 4);

            bool is1type = Convert.ToBoolean(rand.Next(0, 2));
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
