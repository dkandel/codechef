using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        const int MAX = 200;
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int inp = 0; inp < input; inp++)
            {
                factorial(int.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        static void factorial(int n)
        {
            int[] res = new int[MAX];
           
            res[0] = 1;
            int res_size = 1;
            for (int x = 2; x <= n; x++)
            {
                res_size = multiply(x, res, res_size);
            }
            for (int i = res_size-1; i >= 0; i--)
            {
                Console.Write(res[i]);
            }
        }
        static int multiply(int x, int[] res, int res_size)
        {
            int carry = 0;
            for (int i = 0; i < res_size; i++)
            {
                int prod = (res[i] * x) + carry;
                res[i] = prod % 10;
                carry = prod / 10;
            }
            while (carry != 0)
            {
                res[res_size] = carry % 10;
                carry = carry / 10;
                res_size++;
            }
            return res_size;
        }
    }
}
