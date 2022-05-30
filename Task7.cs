using System;

namespace Kek
{
    class Task7
    {
        private string template { get; set; }//print
        private string ans1 { get; set; }//ans
        private string ans2 { get; set; }//ans
        private int m;//print
        private int q;//print
        private int a;//print
        private int b;//print
        private int siG;//print

        public string GetAnsValue()
        {
            return Convert.ToString($"{ans1}, {ans2}");
        }
        public string GetValue()
        {
            return template;
        }

        public Task7()
        {
            var rand = new Random();
            int q = rand.Next(2, 6);
            int b;
            int a;
            do
            {
                b = rand.Next(20, 40);
                a = rand.Next(10,30);
            } while (((b-a)/q)>0 && ((b - a) / q) < 5);
            int m = a - rand.Next(1, 3);
            this.siG = q * 2 + rand.Next(0, 2) - rand.Next(0, 2);
            this.m = m;
            this.q = q;
            this.a = a;
            this.b = b;
            this.ans1 = $"P({a}<X<{b}) = Ф(({b} - {a}) / {q}) - Ф(({a} - {m}) / {q})";
            this.ans2 = $"2Ф({siG} / {q})";
            char sigma = Convert.ToChar(963);
            char delta = Convert.ToChar(948);
            char alpha = Convert.ToChar(945);
            char beta = Convert.ToChar(946);
            this.template = $"Заданы математическое ожидание m и среднее квадратическое отклонение {sigma} нормально распределенной случайной величины х. Найти: a) вероятность того, что х примет значение, принадлежащее интервалу ({alpha}; {beta}); б) вероятность того, что абсолютная величина отклонения | x − m | окажется меньше d. m = {m}, {sigma} = {q}, {alpha} = {a}, {beta} = {b}, {delta} = {siG}.";
        }
    }
}
