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
                string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int a = int.Parse(line[0]);
                int b = int.Parse(line[1]);
                int res = 0;

                for (int k = 1; k <= b; k++)
                {
                    res = MAX(res, a % k);
                }
                Console.WriteLine(res);
            }
            Console.ReadLine();
        }
        static int MAX(int ai, int bi)
        {
            return ai > bi ? ai : bi;
        }
        


    }
}
