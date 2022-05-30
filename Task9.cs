using System;
using System.Collections.Generic;
using System.Text;

namespace Kek
{
    class Task9
    {
        private string template;
        private double y_be;
        private double r_bb;
        private double vib_sr_y;
        private double vib_sr_x;
        private double x_be;
        public string GetAnsValue()
        {
            return $"y{(char)8339}-{y_be} = {r_bb}*{vib_sr_y}(y)/{vib_sr_x}(x)*(x-{x_be})";
        }
        public string GetValue()
        {
            return template;
        }
        public Task9()
        {
            var rand = new Random();
            int n = 6;
            int[] x = new int[n];
            int[] N_iksovoe = new int[n];
            int[] Y = new int[n - 1];
            int[] N_igrikovoe = new int[n - 1];
            int[,] N_IXigrikovoe = new int[n - 1, n];
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
                    N_iksovoe[i] = k;
                    k += 3;
                }
                N_iksovoe[3] = 55;
                k = 15;
                for (int i = 4; i < n; i++)
                {
                    N_iksovoe[i] = k;
                    k -= 9;
                }
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        N_IXigrikovoe[i, j] = -1;
                    }
                }
                N_IXigrikovoe[0, 0] = 5;
                N_IXigrikovoe[0, 1] = 1;
                N_IXigrikovoe[1, 1] = 7;
                N_IXigrikovoe[1, 2] = 2;
                N_IXigrikovoe[2, 2] = 5;
                N_IXigrikovoe[2, 3] = 45;
                N_IXigrikovoe[2, 4] = 2;
                N_IXigrikovoe[3, 2] = 4;
                N_IXigrikovoe[3, 3] = 3;
                N_IXigrikovoe[3, 4] = 8;
                N_IXigrikovoe[4, 3] = 7;
                N_IXigrikovoe[4, 4] = 5;
                N_IXigrikovoe[4, 5] = 6;
            }
            else
            {
                int k = 3;
                for (int i = 0; i < 3; i++)
                {
                    N_iksovoe[i] = k;
                    k += 5;
                }
                N_iksovoe[3] = 51;
                k = 20;
                for (int i = 4; i < n; i++)
                {
                    N_iksovoe[i] = k;
                    k -= 15;
                }

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        N_IXigrikovoe[i, j] = -1;
                    }
                }
                N_IXigrikovoe[0, 0] = 3;
                N_IXigrikovoe[0, 1] = 4;
                N_IXigrikovoe[1, 1] = 4;
                N_IXigrikovoe[1, 2] = 8;
                N_IXigrikovoe[2, 2] = 4;
                N_IXigrikovoe[2, 3] = 29;
                N_IXigrikovoe[2, 4] = 6;
                N_IXigrikovoe[3, 2] = 1;
                N_IXigrikovoe[3, 3] = 17;
                N_IXigrikovoe[3, 4] = 1;
                N_IXigrikovoe[4, 3] = 5;
                N_IXigrikovoe[4, 4] = 13;
                N_IXigrikovoe[4, 5] = 5;
            }
            bool F3 = Convert.ToBoolean(rand.Next(0, 2));
            if (F3 == true)
            {
                int k = 10;
                for (int i = 0; i < n - 1; i++)
                {
                    Y[i] = k;
                    k += 10;
                }
            }
            else
            {
                int k = 20;
                for (int i = 0; i < n - 1; i++)
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
                    N_igrikovoe[i] = k;
                    k += 3;
                }
                N_igrikovoe[2] = 52;
                k = 15;
                for (int i = 3; i < n - 1; i++)
                {
                    N_igrikovoe[i] = k;
                    k += 3;
                }
            }
            else
            {
                int k = 7;
                for (int i = 0; i < 2; i++)
                {
                    N_igrikovoe[i] = k;
                    k += 5;
                }
                N_igrikovoe[2] = 39;
                k = 19;
                for (int i = 3; i < n - 1; i++)
                {
                    N_igrikovoe[i] = k;
                    k += 4;
                }
            }
            double x_be = 0;
            int sum_N = 0;
            for (int i = 0; i < n; i++)
            {
                x_be += x[i] * N_iksovoe[i];
                sum_N += N_iksovoe[i];
            }
            x_be /= sum_N; 
            this.x_be = x_be;
            double y_be = 0;
            for (int i = 0; i < n-1; i++)
            {
                y_be += Y[i] * N_igrikovoe[i];
            }
            y_be /= sum_N;
            this.y_be = y_be;
            double vib_disp_x = 0;
            for (int i = 0; i < n; i++)
            {
                vib_disp_x += Math.Pow(x[i], 2) * N_iksovoe[i];
            }
            vib_disp_x = (vib_disp_x / sum_N) - Math.Pow(x_be, 2);
            double vib_sr_x = Math.Sqrt(vib_disp_x);
            this.vib_sr_x = vib_sr_x;
            double vib_disp_y = 0;
            for (int i = 0; i < n - 1; i++)
            {
                vib_disp_y += Math.Pow(Y[i], 2) * N_igrikovoe[i];
            }
            vib_disp_y = (vib_disp_y / sum_N) - Math.Pow(y_be, 2);
            double vib_sr_y = Math.Sqrt(vib_disp_y);
            this.vib_sr_y = vib_sr_y;
            double r_bb = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    r_bb += N_IXigrikovoe[i, j] * x[j] * Y[i];
                }
            }
            r_bb = Math.Abs(r_bb);
            this.r_bb = r_bb;
            double perv = sum_N * x_be * y_be;
            double vtor = sum_N * vib_sr_x * vib_sr_y;
            r_bb =Math.Round((r_bb - perv) / vtor,4);
            //подставляем в формулу значения y_be,r_bb,vib_sr_y,vib_sr_x,x_be
            string template;
            template = $"Найти выборочное уравнение прямой y{(char)8339}-{(char)375} = r(b)*{(char)1005}(y)/{(char)1005}(x)*(x-{(char)7819})  регрессии Y на Х по данной корреляционной таблице:";
            this.template = template;
        }
    }
}
