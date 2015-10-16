//Cutting receipes 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                string[] inputs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] inps = Array.ConvertAll(inputs, x => int.Parse(x));
                int gcd=0;
                int arrlen = inps[0];
                int[] output = new int[arrlen];
                for (int j = 1; j < inps.Count(); j++)
                {
                    int a = inps[j];
                    output[j - 1] = a;
                    if (j - 1 == 0)
                    {
                        gcd = a;
                    }
                    else
                    {
                        gcd = GCD(gcd, a);
                    }
                }
                foreach (int k in output)
                {
                    Console.Write(k / gcd + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }


        static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return (GCD(b, a % b));
            }
        }
    }
}
