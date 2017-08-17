using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mass = { 10, 2, 24, 21, 54, 12, 5, 12, 21, 3 };
            double[] mass_unsort = (double[])mass.Clone();

            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = i + 1; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        double tmp = mass[j];
                        mass[j] = mass[i];
                        mass[i] = tmp;
                    }                      
                }
            }

            foreach (double count in mass)
                Console.WriteLine(count);
            Console.WriteLine("---------------------------------------------------");
            Array.Sort(mass_unsort);
            foreach (double count in mass_unsort)
                Console.WriteLine(count);

        }
    }
}
