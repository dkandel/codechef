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
                char[] line = Console.ReadLine().ToCharArray();
                Stack<char> ops = new Stack<char>();
                char opFound;
                StringBuilder postFix = new StringBuilder();
                for (int j = 0; j < line.Length; j++)
                {
                    char c =line[j];

                    if (c != '(' && c != ')' && c != '*' && c != '+' && c != '/' && c != '-' && c != '^')
                    {
                        postFix.Append(c);
                    }
                    else if(c=='(')
                    {
                        ops.Push(c);
                    }
                    else if(c==')')
                    {
                        opFound = ops.Pop();
                        while (opFound != '(')
                        {
                            postFix.Append(opFound);
                            opFound = ops.Pop();
                        }
                    }
                    else
                    {
                        if((ops.Count!=0)&& Predecessor(ops.Peek(),c)){
                            opFound = ops.Pop();
                            while(Predecessor(opFound,c)){
                                postFix.Append(opFound);
                                if (ops.Count == 0)
                                    break;
                                opFound = ops.Pop();
                            }
                            ops.Push(c);
                        }
                        else
                        {
                            ops.Push(c);
                        }
                    }


                }
                while (ops.Count > 0)
                {
                    opFound = ops.Pop();
                    postFix.Append(opFound);
                }
                Console.WriteLine(postFix.ToString());
               
            }
            Console.ReadLine();
        }
        private static bool Predecessor(char firstOperator, char secondOperator)
        {
            string opString = "(+-*/^";

            int firstPoint, secondPoint;

            int[] precedence = { 0, 12, 12, 13, 13, 13 };// "(" has less prececence

            firstPoint = opString.IndexOf(firstOperator);
            secondPoint = opString.IndexOf(secondOperator);

            return (precedence[firstPoint] >= precedence[secondPoint]) ? true : false;
        }
    }
}
        


    

