using System;
using System.Collections.Generic;
using System.Text;

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

        private double func1(double x)
        {
            var rand = new Random();
            int y1 = rand.Next(0, 2);
            int a = rand.Next(0, 4);
            int y3 = rand.Next(1, 10);
            int y4 = rand.Next(0, 12);
            return x * x * x * y1 + x * x * a + x * y3 + y4;
        }

        private double func2(double x)
        {
            var rand = new Random();
            int a = rand.Next(1, 10);
            int y2 = rand.Next(1, 5);
            return a/(x * x * y2);
        }

        private double func3(double x)
        {
            var rand = new Random();
            int a = rand.Next(1, 10);
            int y2 = rand.Next(1, 5);
            return a / (x * y2);
        }

        public Task6()
        {
            var rand = new Random();
            int choiceFunc = rand.Next(1, 4);
            //int aFrom 
        }

    }
}
