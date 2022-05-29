using System;

namespace Kek
{
    class Task8
    {
        private string template { get; set; }

        public string GetValue()
        {
            return template;
        }

        public Task8()
        {
            int n = 7;
            var rand = new Random();
            bool F1 = Convert.ToBoolean(rand.Next(0, 2));
            int[] x = new int [n];
            int[] N = new int [n];
            if (F1 == true)
            {
                int k = 94;
                for(int i = 0; i < n; i++)
                {
                    x[i] = k;
                    k += 10;
                }
            }
            else
            {
                int k = 102;
                for (int i = 0; i < n; i++)
                {
                    x[i] = k;
                    k += 10;
                }
            }
            bool F2 = Convert.ToBoolean(rand.Next(0, 2));
            if (F2 == true)
            {
                int k = 2;
                for (int i = 0; i < 3; i++)
                {
                    N[i] = k;
                    k += 6;
                }
                N[3] = 25;
                k = 21;
                for (int i = 4; i < n; i++)
                {
                    N[i] = k;
                    k -= 4;
                }
            }
            else
            {
                int k = 6;
                for (int i = 0; i < 3; i++)
                {
                    N[i] = k;
                    k += 3;
                }
                N[3] = 37;
                k = 17;
                for (int i = 4; i < n; i++)
                {
                    N[i] = k;
                    k -= 5;
                }
            }
            double vib_sr = 0;
            int sum_N = 0;
            for (int i = 0; i < n; i++)
            {
                vib_sr += x[i] * N[i];
                sum_N += N[i];
            }
            vib_sr /= sum_N;//ответ
            double vib_disp = 0;
            for (int i = 0; i < n; i++)
            {
                vib_disp += Math.Pow(x[i],2) * N[i];
            }
            vib_disp = (vib_disp / sum_N) - Math.Pow(vib_sr, 2);
            double vib_sr_sq = Math.Sqrt(vib_disp);//ответ
            double Stud = 1.943;
            double lev_gran = vib_sr - Stud * (vib_sr_sq / Math.Sqrt(n));
            double prav_gran = vib_sr + Stud * (vib_sr_sq / Math.Sqrt(n));//ответ - целое между ними
            double toch = Stud * (vib_sr_sq / Math.Sqrt(n));//точность оценки
            double u;
            double Fi;
            double h = 0.2;
            double Nuu = 0;
            double nabl_znach = 0;
            for (int i = 0; i < n; i++)
            {
                u = (x[i] - vib_sr) / vib_sr_sq;
                Fi = Math.Exp((-Math.Pow(u, 2)) / 2) / Math.Sqrt(2 * Math.PI);
                Nuu = ((sum_N * h) / vib_sr_sq) * Fi;
                nabl_znach += (Math.Pow((N[i] - Nuu), 2) / Nuu);//часть ответа
                //из таблицы как-то берется критические значения, если nabl_znach<krit_znach, то гипотезу принимают, иначе нет, не понял как с таблицей работать
            }
            char aa = Convert.ToChar(945);
            char gamma = Convert.ToChar(947);
            string xI = "|  xi   |";
            string nI = "|  ni   |";
            template = $"Дано статистическое распределение выборки: в первой строке указаны выборочные варианты хi, а во второй строке – соответственные частоты ni количественного признака Х). Требуется найти:\n1.Методом произведений: а) выборочную среднюю; б) выборочное среднее квадратическое отклонение;\n2.Доверительные интервалы для оценки неизвестного математического ожидания а с заданной надежностью {gamma} = 0,95.\n3.Пользуясь критерием Пирсона, при уровне значимости {aa} = 0,05, установить, согласуется ли гипотеза о нормальном распределении генеральной совокупности с данными выборки объема n = {sum_N}:";
            foreach (int aX in x)
            {
                //xI = xI + $"{aX,7:G}|";
                xI = xI + $"{aX}\t|";
            }
            foreach (int aN in N)
            {
                //nI = nI + $"{aN,7:G}|";
                nI = nI + $"{aN}\t|";
            }
            template = template + "\n" + xI + "\n" + nI;
            //1. a) vib_sr б) vib_sr_sq 2. lev_gran < Тут целое, которое определяет студент < prav_gran 3. nabl_znach предположительно 
        }
    }
}
