using System;
using System.Collections.Generic;
using System.Text;

namespace Kek
{
    class Task9
    {
        public Task9()
        {
            var rand = new Random();
            int n = 6;
            int[] x = new int[n];
            int[] N = new int[n];
            int[] Y = new int[n-1];
            bool F1 = Convert.ToBoolean(rand.Next(0, 2));
            if (F1 == true)
            {
                int k = 10;
                for (int i = 0; i < n; i++)
                {
                    x[i] = k;
                    k += 5;
                }
            }
            else
            {
                int k = 15;
                for (int i = 0; i < n; i++)
                {
                    x[i] = k;
                    k += 5;
                }
            }
            bool F2 = Convert.ToBoolean(rand.Next(0, 2));
            if (F2 == true)
            {
                int k = 5;
                for (int i = 0; i < 3; i++)
                {
                    N[i] = k;
                    k += 3;
                }
                N[3] = 55;
                k = 15;
                for (int i = 4; i < n; i++)
                {
                    N[i] = k;
                    k -= 9;
                }
            }
            else
            {
                int k = 3;
                for (int i = 0; i < 3; i++)
                {
                    N[i] = k;
                    k += 5;
                }
                N[3] = 52;
                k = 22;
                for (int i = 4; i < n; i++)
                {
                    N[i] = k;
                    k -= 15;
                }
            }
            bool F3 = Convert.ToBoolean(rand.Next(0, 2));
            if (F3 == true)
            {
                int k = 10;
                for (int i = 0; i < n-1; i++)
                {
                    Y[i] = k;
                    k += 10;
                }
            }
            else
            {
                int k = 20;
                for (int i = 0; i < n-1; i++)
                {
                    Y[i] = k;
                    k += 10;
                }
            }
            double x_be = 0;
            int sum_N = 0;
            for(int i = 0; i < n; i++)
            {
                x_be += x[i] * N[i];
                sum_N += N[i];
            }
            x_be /= sum_N;
            double y_be = 0;
            for (int i = 0; i < n; i++)
            {
                y_be += Y[i] * N[i];
            }
            y_be /= sum_N;
        }
    }
}
