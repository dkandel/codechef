using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechef
{
    class Program
    {
        static void Main(string[] args)
        {

            int numTestCases;
            numTestCases = int.Parse(Console.ReadLine());
            int[] res = new int[numTestCases+1];
            int[] report = new int[numTestCases];
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < numTestCases;i++ )
            {
                report[i] = int.Parse(input[i]);
            }
            for (int j = 0; j < numTestCases; j++)
            {
                int inpVal = report[j];
                res[inpVal] += 1;
            }
            for (int k = 1; k <= numTestCases; k++)
            {
                if (res[k] == 0)
                {
                    Console.Write(k + " ");
                }
            }

                Console.ReadLine();
        }
    }
}
