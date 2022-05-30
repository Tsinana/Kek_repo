using System;

namespace Kek
{
    class Task6
    {
        private string template { get; set; }//prdouble
        private double a;//ans
        private double mX;//ans
        private double dX;//ans
        private double qQ;//ans
        private double aFrom;//prdouble
        private double bTo;//prdouble
        public string GetAnsValue()
        {
            double mX = Math.Round(this.mX, 4);
            double dX = Math.Round(this.dX, 4);
            return Convert.ToString($"А = {a}, M(x) = {mX}, D(x) = {dX}");
        }
        public string GetValue()
        {
            return template;
        }

        private double func1(double x,double y1,double a, double y3, double y4)
        {
            return x * x * x * y1 + x * x * a + x * y3 + y4;
        }
        private double func1x(double x, double y1, double a, double y3, double y4)
        {
            return (x * x * x * y1 + x * x * a + x * y3 + y4)*x;
        }
        private double func1xx(double x, double y1, double a, double y3, double y4)
        {
            return (x * x * x * y1 + x * x * a + x * y3 + y4)*x*x;
        }

        private double func2(double x,double a, double y2)
        {
            return a/(x * x * y2);
        }
        private double func2x(double x, double a, double y2)
        {
            return (a / (x * x * y2))*x;
        }
        private double func2xx(double x, double a, double y2)
        {
            return (a / (x * x * y2))*x*x;
        }

        private double func3(double x, double a, double y2 )
        {
            return a / (x * y2);
        }
        private double func3x(double x, double a, double y2)
        {
            return (a / (x * y2))*x;
        }
        private double func3xx(double x, double a, double y2)
        {
            return (a / (x * y2))*x*x;
        }

        private double trapezoidaldoubleegral(double a, double b, double n, Func<double, double> f)
        {
            double width = (b - a) / n;
            double trapezoidal_doubleegral = 0;
            for (double step = 0; step < n; step++)
            {
                double x1 = a + step * width;
                double x2 = a + (step + 1) * width;

                trapezoidal_doubleegral += 0.5 * (x2 - x1) * (f(x1) + f(x2));
            }
            return trapezoidal_doubleegral;
        }

       /* double Runge(double a, double b, double n0, double eps, Func<double, double> f)
        {
            double n = n0;
            double F1 = trapezoidaldoubleegral(a, b, n, f);
            double F2 = trapezoidaldoubleegral(a, b, 2 * n, f);
            double diff = F2 - F1;
            while (Math.Abs(diff) >= eps)
            {
                n = 2 * n;
                F1 = trapezoidaldoubleegral(a, b, n, f);
                F2 = trapezoidaldoubleegral(a, b, 2 * n, f);
                diff = F2 - F1;
            }
            return n;
        }*/

        public Task6()
        {
            var rand = new Random();
            double choiceFunc = rand.Next(1, 4);
            double aFrom = rand.Next(0, 2);
            double bTo = aFrom + rand.Next(1, 3);
            this.aFrom = aFrom;
            this.bTo = bTo;
            double y1 =0; double y3 =0; double y4 =0; double y2 =0;
            double a =0; double n = 10000;
            double width; double trapezoidal_doubleegral;
            switch (choiceFunc)
            {
                case (1):
                    y1 = rand.Next(0, 2);
                    a = rand.Next(1, 4);
                    y3 = rand.Next(1, 10);
                    y4 = rand.Next(0, 12);

                    width = (bTo - aFrom) / n;
                    trapezoidal_doubleegral = 0;
                    for (double step = 0; step < n; step++)
                    {

                        double x1 = a + step * width;
                        double x2 = a + (step + 1) * width;

                        trapezoidal_doubleegral += 0.5 * (x2 - x1) * (func1x(x1, y1, a, y3, y4) + func1x(x2, y1, a, y3, y4));
                    }
                    this.mX = trapezoidal_doubleegral;

                    width = (bTo - aFrom) / n;
                    trapezoidal_doubleegral = 0;
                    for (double step = 0; step < n; step++)
                    {
                        double x1 = a + step * width;
                        double x2 = a + (step + 1) * width;

                        trapezoidal_doubleegral += 0.5 * (x2 - x1) * (func1xx(x1, y1, a, y3, y4) + func1xx(x2, y1, a, y3, y4));
                    }
                    this.dX = trapezoidal_doubleegral;

                    this.qQ = Math.Sqrt(dX);
                    break;

                case (2):
                    a = rand.Next(1, 10);
                    y2 = rand.Next(1, 5);

                    width = (bTo - aFrom) / n;
                    trapezoidal_doubleegral = 0;
                    for (double step = 0; step < n; step++)
                    {
                        double x1 = a + step * width;
                        double x2 = a + (step + 1) * width;

                        trapezoidal_doubleegral += 0.5 * (x2 - x1) * (func2x(x1,a, y2) + func2x(x1, a, y2));
                    }
                    this.mX = trapezoidal_doubleegral;

                    width = (bTo - aFrom) / n;
                    trapezoidal_doubleegral = 0;
                    for (double step = 0; step < n; step++)
                    {
                        double x1 = a + step * width;
                        double x2 = a + (step + 1) * width;

                        trapezoidal_doubleegral += 0.5 * (x2 - x1) * (func2xx(x1, a, y2) + func2xx(x1, a, y2));
                    }
                    this.dX = trapezoidal_doubleegral;

                    this.qQ = Math.Sqrt(dX);
                    break;

                case (3):
                    a = rand.Next(1, 10);
                    y2 = rand.Next(1, 5);

                    width = (bTo - aFrom) / n;
                    trapezoidal_doubleegral = 0;
                    for (double step = 0; step < n; step++)
                    {
                        double x1 = a + step * width;
                        double x2 = a + (step + 1) * width;

                        trapezoidal_doubleegral += 0.5 * (x2 - x1) * (func3x(x1, a, y2) + func3x(x1, a, y2));
                    }
                    this.mX = trapezoidal_doubleegral;

                    width = (bTo - aFrom) / n;
                    trapezoidal_doubleegral = 0;
                    for (double step = 0; step < n; step++)
                    {
                        double x1 = a + step * width;
                        double x2 = a + (step + 1) * width;

                        trapezoidal_doubleegral += 0.5 * (x2 - x1) * (func3xx(x1, a, y2) + func3xx(x1, a, y2));
                    }
                    this.dX = trapezoidal_doubleegral;

                    this.qQ = Math.Sqrt(dX);
                    break;
            }
            this.a = a;

            template = "Задана плотность распределения случайной величины";
            char bracket1 = Convert.ToChar(9136);
            char bracket2 = Convert.ToChar(9137);
            char smallor = Convert.ToChar(8804);
            string strF1="";
            string strF2 = "";
            string strF3 = "";
            char degree2 = Convert.ToChar(178);
            char degree3 = Convert.ToChar(179);
            char umn = Convert.ToChar(8729);
            switch (choiceFunc)
            {
                case (1):
                     strF1 = $"f(x) = {bracket1} 0,\t x {smallor}, {aFrom}\tx > {bTo}";
                     strF2 = $"\t{bracket2} x{degree3}{umn}{y1}+x{degree2}{umn}A+x{umn}{y3}+{y4}\t{aFrom} < x {smallor} {bTo}";
                    break;
                case (2):
                    strF1 = $"f(x) = {bracket1} 0,\t x {smallor}, {aFrom}\tx > {bTo}";
                    strF2 = $"\t{bracket2} A/(x{degree2}{umn}{y2})\t{aFrom} < x {smallor} {bTo}";
                    break;
                case (3):
                    strF1 = $"f(x) = {bracket1} 0,\t x {smallor}, {aFrom}\tx > {bTo}";
                    strF2 = $"\t{bracket2} A/(x{umn}{y2})\t{aFrom} < x {smallor} {bTo}";
                    break;
            }
            template = template + "\n" + strF1 + "\n" + strF2 + "\n" + strF3 + "\n" + "Найти параметр А, интегральную функцию распределения, математическое ожидание, дисперсию и среднее квадратическое отклонение.";
        }
    }
}
