using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class RootWithNewton
    {
        public static double Root(double number, int power, double accuracy = 0.000001)
        {
            if (number < 0 || power < 1 || accuracy > 0.1 || accuracy <= 0) throw new ArgumentException();
            double xfirst, xlast;
            xlast = number;
            do
            {
                xfirst = xlast;
                xlast = (1.0 / power) * ((power - 1) * xfirst + number / Power(xfirst, power - 1));
            }
            while ((xfirst - xlast) > accuracy);
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
