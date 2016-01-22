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
                int N = int.Parse(Console.ReadLine());
                int reverse = 0;
                while (N > 0)
                {
                    reverse = reverse * 10;
                    reverse += N % 10;
                    N = N / 10;
                }
                
                Console.WriteLine(reverse);
            }
            Console.ReadLine();
        }

    }
}
