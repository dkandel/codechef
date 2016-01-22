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
                //string[] line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //int a = int.Parse(line[0]);
                //int b = int.Parse(line[1]);
                int N = int.Parse(Console.ReadLine());
                int res = 0;
                res = res + N / 100;
                N = N % 100;
                if (N != 0)
                {
                    res = res + N / 50;
                    N = N % 50;

                    if (N != 0)
                    {
                        res = res + N / 10;
                        N = N % 10;

                        if (N != 0)
                        {
                            res = res + N / 5;
                            N = N % 5;

                            if (N != 0)
                            {
                                res = res + N / 2;
                                N = N % 2;

                                if (N != 0)
                                {
                                    res = res + N / 1;
                                    N = N % 1;
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(res);
            }
            Console.ReadLine();
        }
    }
}

