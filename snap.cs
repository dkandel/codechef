//Snape and Ladder using System;
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
                double minVal =Math.Sqrt(Math.Pow(inps[1], 2) - Math.Pow(inps[0], 2));
                double maxVal = Math.Sqrt(Math.Pow(inps[0], 2) + Math.Pow(inps[1], 2));
                Console.WriteLine(Math.Round(minVal,4) + " " + Math.Round(maxVal,4));
               

            }
            Console.ReadLine();
        }
    }
}
