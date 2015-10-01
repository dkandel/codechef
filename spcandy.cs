// https://www.codechef.com/problems/SPCANDY
using System;
using System.Collections.Generic;
    class Program
    {
        public static void Main()
        {
            String input = Console.ReadLine();
            int testCases;
            if (!int.TryParse(input, out testCases))
            {
                return;
            }

            for (int i = 0; i < testCases; i++)
            {
                long NumberOfStudents, NumberOfCandies;
                long CandiesToStudents = 0, RemainingCandies = 0;
                string[] inputs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                NumberOfStudents = long.Parse(inputs[1]);
                NumberOfCandies = long.Parse(inputs[0]);

                if (NumberOfStudents != 0)
                {
                    CandiesToStudents = NumberOfCandies / NumberOfStudents;
                    RemainingCandies = NumberOfCandies % NumberOfStudents;
                    Console.WriteLine(CandiesToStudents + " " + RemainingCandies);
                }
                else
                {
                    Console.WriteLine(0 + " " + NumberOfCandies);
                }

            }
            
            Console.ReadLine();
        }

    }

