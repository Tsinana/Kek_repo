using System;
using System.Collections.Generic;
using System.Text;

namespace Kek
{
    public class Task1
    {
        private string template;//print
        private int quantityBlackBalls;//
        private int quantityWhiteBalls;//
        private int quantityAllBalls;
        private int quantityTakeBalls;//
        private int ofThem;//
        private bool isWhite;//
        private double probabilityability;//ans//ща в тл з

        public string GetAnsValue()
        {
            return Convert.ToString(probabilityability);
        }

        public string GetValue()
        {
            return template;
        }


        public Task1()
        {
            var rand = new Random();

            
            this.quantityAllBalls = rand.Next(9, 21);//всего шаров
            this.quantityWhiteBalls = rand.Next(3, quantityAllBalls - 3);//белых
            this.quantityBlackBalls = quantityAllBalls - quantityWhiteBalls;//черных
               
            if (quantityWhiteBalls > quantityBlackBalls)
            {

                this.ofThem = rand.Next(3, quantityBlackBalls);//из них
                this.isWhite = false;
                this.quantityTakeBalls = rand.Next(quantityBlackBalls, quantityWhiteBalls);
            }
            else
            {
                this.ofThem = rand.Next(3, quantityWhiteBalls);
                this.isWhite = true;
                this.quantityTakeBalls = rand.Next(quantityWhiteBalls, quantityBlackBalls);
            }
            


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

        private double Sochet(int a, int b)
        {
            return Factorial(a) / (Factorial(a - b) * Factorial(b));
        }
    }

}
