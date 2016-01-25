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
                long arrSize = int.Parse(Console.ReadLine());
                string[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] arry = new int[arrSize];
                for (int k = 0; k < arrSize; k++)
                {
                    arry[k] = int.Parse(arr[k]);
                }
                Array.Sort(arry);
                Console.WriteLine(arry[0] * (arrSize - 1));
            }
            Console.ReadLine();
        }
        
        
    }
}
        


    

