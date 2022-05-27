using System;

namespace Kek
{
    class Task6
    {
        private string template { get; set; }//print
        private int a;//ans
        private double mX;//ans
        private double dX;//ans
        private double qQ;//ans
        private int aFrom;//print
        private int bTo;//print

        private double func1(double x,int y1,int a, int y3, int y4)
        {
            return x * x * x * y1 + x * x * a + x * y3 + y4;
        }
        private double func1x(double x, int y1, int a, int y3, int y4)
        {
            return (x * x * x * y1 + x * x * a + x * y3 + y4)*x;
        }
        private double func1xx(double x, int y1, int a, int y3, int y4)
        {
            return (x * x * x * y1 + x * x * a + x * y3 + y4)*x*x;
        }

        private double func2(double x,int a, int y2)
        {
            return a/(x * x * y2);
        }
        private double func2x(double x, int a, int y2)
        {
            return (a / (x * x * y2))*x;
        }
        private double func2xx(double x, int a, int y2)
        {
            return (a / (x * x * y2))*x*x;
        }

        private double func3(double x, int a, int y2 )
        {
            return a / (x * y2);
        }
        private double func3x(double x, int a, int y2)
        {
            return (a / (x * y2))*x;
        }
        private double func3xx(double x, int a, int y2)
        {
            return (a / (x * y2))*x*x;
        }

        private double trapezoidalIntegral(double a, double b, int n, Func<double, double> f)
        {
            double width = (b - a) / n;
            double trapezoidal_integral = 0;
            for (int step = 0; step < n; step++)
            {
                double x1 = a + step * width;
                double x2 = a + (step + 1) * width;

                trapezoidal_integral += 0.5 * (x2 - x1) * f(x1) + f(x2);
            }
            return trapezoidal_integral;
        }

       /* double Runge(double a, double b, int n0, double eps, Func<double, double> f)
        {
            int n = n0;
            double F1 = trapezoidalIntegral(a, b, n, f);
            double F2 = trapezoidalIntegral(a, b, 2 * n, f);
            double diff = F2 - F1;
            while (Math.Abs(diff) >= eps)
            {
                n = 2 * n;
                F1 = trapezoidalIntegral(a, b, n, f);
                F2 = trapezoidalIntegral(a, b, 2 * n, f);
                diff = F2 - F1;
            }
            return n;
        }*/

        public Task6()
        {
            var rand = new Random();
            int choiceFunc = rand.Next(1, 4);
            int aFrom = rand.Next(0, 2);
            int bTo = aFrom + rand.Next(1, 3);
            this.aFrom = aFrom;
            this.bTo = bTo;
            int y1; int y3; int y4; int y2;
            int a=0; int n = 10000;
            double width; double trapezoidal_integral;
            switch (choiceFunc)
            {
                case (1):
                    y1 = rand.Next(0, 2);
                    a = rand.Next(1, 4);
                    y3 = rand.Next(1, 10);
                    y4 = rand.Next(0, 12);

                    width = (bTo - aFrom) / n;
                    trapezoidal_integral = 0;
                    for (int step = 0; step < n; step++)
                    {
                        double x1 = a + step * width;
                        double x2 = a + (step + 1) * width;

                        trapezoidal_integral += 0.5 * (x2 - x1) * func1x(x1, y1, a, y3, y4) + func1x(x2, y1, a, y3, y4);
                    }
                    this.mX = trapezoidal_integral;

                    width = (bTo - aFrom) / n;
                    trapezoidal_integral = 0;
                    for (int step = 0; step < n; step++)
                    {
                        double x1 = a + step * width;
                        double x2 = a + (step + 1) * width;

                        trapezoidal_integral += 0.5 * (x2 - x1) * func1xx(x1, y1, a, y3, y4) + func1xx(x2, y1, a, y3, y4);
                    }
                    this.dX = trapezoidal_integral;

                    this.qQ = Math.Sqrt(dX);
                    break;

                case (2):
                    a = rand.Next(1, 10);
                    y2 = rand.Next(1, 5);

                    width = (bTo - aFrom) / n;
                    trapezoidal_integral = 0;
                    for (int step = 0; step < n; step++)
                    {
                        double x1 = a + step * width;
                        double x2 = a + (step + 1) * width;

                        trapezoidal_integral += 0.5 * (x2 - x1) * func2x(x1,a, y2) + func2x(x1, a, y2);
                    }
                    this.mX = trapezoidal_integral;

                    width = (bTo - aFrom) / n;
                    trapezoidal_integral = 0;
                    for (int step = 0; step < n; step++)
                    {
                        double x1 = a + step * width;
                        double x2 = a + (step + 1) * width;

                        trapezoidal_integral += 0.5 * (x2 - x1) * func2xx(x1, a, y2) + func2xx(x1, a, y2);
                    }
                    this.dX = trapezoidal_integral;

                    this.qQ = Math.Sqrt(dX);
                    break;

                case (3):
                    a = rand.Next(1, 10);
                    y2 = rand.Next(1, 5);

                    width = (bTo - aFrom) / n;
                    trapezoidal_integral = 0;
                    for (int step = 0; step < n; step++)
                    {
                        double x1 = a + step * width;
                        double x2 = a + (step + 1) * width;

                        trapezoidal_integral += 0.5 * (x2 - x1) * func3x(x1, a, y2) + func3x(x1, a, y2);
                    }
                    this.mX = trapezoidal_integral;

                    width = (bTo - aFrom) / n;
                    trapezoidal_integral = 0;
                    for (int step = 0; step < n; step++)
                    {
                        double x1 = a + step * width;
                        double x2 = a + (step + 1) * width;

                        trapezoidal_integral += 0.5 * (x2 - x1) * func3xx(x1, a, y2) + func3xx(x1, a, y2);
                    }
                    this.dX = trapezoidal_integral;

                    this.qQ = Math.Sqrt(dX);
                    break;
            }
            this.a = a;
            this.template = "Задана плотность распределения случайной величины !!! Найти параметр А, интегральную функцию распределения, математическое ожидание, дисперсию и среднее квадратическое отклонение.";
        }
    }
}
