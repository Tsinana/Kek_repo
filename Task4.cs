using System;
using System.Collections.Generic;
using System.Text;

namespace Kek
{
    class Task4
    {
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
            //Значение функций считать по таблице ептаааа//
        }
    }
}
