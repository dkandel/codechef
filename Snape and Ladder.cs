using System;

namespace factorial
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                
                string[] line = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
                double B = double.Parse(line[0]);
                double LS = double.Parse(line[1]);
                double maxLen = MaxLen(B, LS);
                double minLen = MinLen(B, LS);
                Console.WriteLine(Math.Round((decimal)minLen, 5) + " " + Math.Round((decimal)maxLen, 5));
            }
            Console.ReadLine();
        }

        static double MaxLen(double dbase, double dperpendicular)
        {
            double res = Math.Sqrt(Math.Pow(dbase, 2) + Math.Pow(dperpendicular, 2));
            return res;
        }
        static double MinLen(double dbase, double dhypotenus)
        {
            double res = Math.Sqrt(Math.Pow(dhypotenus, 2) - Math.Pow(dbase, 2));
            return res;
        }
        
    }
}
