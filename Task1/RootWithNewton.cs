using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class RootWithNewton
    {
        private const double accuracy = 0.000001;
        private static double xfirst, xlast = 0;
        public static double Root(double number, int power)
        {
            if (number < 0 || power < 1 || number > 999999) throw new ArgumentException();
            xfirst = 10000001;
            xlast = 10000000;
            while ((xfirst - xlast) > accuracy)
            {
                xfirst = xlast;
                xlast = (1 / (double)power) * ((power - 1) * xfirst + number / Power(xfirst, power - 1));
            }  
            return xlast;
        }

        private static double Power(double number, int power)
        {
            double answer = number;
            while (power > 1)
            {
                answer *= number;
                --power;
            }
            return answer;
        }
    }
}
