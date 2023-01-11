using System;

namespace lab_06
{
    class Program
    {
        static double Sum(double nn, double nk)
        {
            double sum = 0;

            while (nn <= nk)
            {
                double a = (Math.Pow(nn,2)+Math.Pow((-1),nn-1)*(2*nn)-1)/
                           (Math.Pow(nn,2)-8);
                sum += a;
                nn++;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть nn та nk");
            Console.WriteLine(Sum(Convert.ToDouble(Console.ReadLine()),Convert.ToDouble(Console.ReadLine())));
        }
    }
}