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
            int[] N_igrikovoe = new int[n - 1];
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
            if (F2 == true)
            {
                int k = 6;
                for (int i = 0; i < 2; i++)
                {
                    N[i] = k;
                    k += 3;
                }
                N[2] = 52;
                k = 15;
                for (int i = 3; i < n-1; i++)
                {
                    N[i] = k;
                    k += 3;
                }
            }
            else
            {
                int k = 9;
                for (int i = 0; i < 2; i++)
                {
                    N[i] = k;
                    k += 5;
                }
                N[2] = 40;
                k =19;
                for (int i = 3; i < n-1; i++)
                {
                    N[i] = k;
                    k += 4;
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
            double vib_disp_x = 0;
            for (int i = 0; i < n; i++)
            {
                vib_disp_x += Math.Pow(x[i], 2) * N[i];
            }
            vib_disp_x = (vib_disp_x / sum_N) - Math.Pow(x_be, 2);
            double vib_sr_x = Math.Sqrt(vib_disp_x);
            double vib_disp_y = 0;
            for (int i = 0; i < n-1; i++)
            {
                vib_disp_y += Math.Pow(Y[i], 2) * N_igrikovoe[i];
            }
            vib_disp_y = (vib_disp_y / sum_N) - Math.Pow(y_be, 2);
            double vib_sr_y = Math.Sqrt(vib_disp_y);//все значения посчитаны, нужно только как-то матрицу представить и оттуда значения тянуть в формулу, хз как представить, чтобы выводить, как и в 9-ой
        }
    }
}
