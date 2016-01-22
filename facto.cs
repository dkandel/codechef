using System;
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

                //string[] line = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
                //int a = int.Parse(line[0]);
                //int b = int.Parse(line[1]);
                string input = Console.ReadLine();
                int N = int.Parse(input);
               
                Console.WriteLine(fact(N));
            }
            Console.ReadLine();
        }
        static int fact(int n)
        {
            if (n == 0||n==1)
            {
                return 1;
            }
            else{
                return (fact(n-1) * n);
            }
            
        }


    }
}
