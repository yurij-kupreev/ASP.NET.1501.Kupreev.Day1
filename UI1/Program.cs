using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace UI1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            int root;
            bool rightNumber, rightRoot;
            rightNumber = double.TryParse(args[0], out number);
            rightRoot =  int.TryParse(args[1], out root);
            try
            {
                if (!rightNumber || !rightRoot) throw new ArgumentException("Неверно заданы входные данные");
                Console.WriteLine("Метод Ньютона: {0, 1:F6}", RootWithNewton.Root(number, root));
                Console.WriteLine("С помощью метода Math.Pow: {0, 1:F6}", Math.Pow((double)number, (double)1 / root));
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            
        }
    }
}
