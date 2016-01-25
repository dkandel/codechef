using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace factorial
{
    class Program
    {

        static void Main(string[] args)
        {

            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
               // string inp = Console.ReadLine();
                int gcdValue = gcd(int.Parse(input[0]), int.Parse(input[1]));
                int lcmValue = (int.Parse(input[0]) * int.Parse(input[1])) / gcdValue;
                Console.WriteLine(gcdValue+" "+lcmValue);
                
            }
            Console.ReadLine();
        }
        static int gcd(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                return gcd(b % a, a);
            }
        }
        
        
    }
}
        


    

