using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sumoftriangle
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int input = int.Parse(Console.ReadLine());
            for (int inp = 0; inp < input; inp++)
            {
                
                int matrix_size = int.Parse(Console.ReadLine());
                int[,] matrix = new int[matrix_size, matrix_size];
                
                for (int row = 0; row < matrix_size; row++)
                {
                    string[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int col = 0; col < row+1; col++)
                    {
                        matrix[row, col] = int.Parse(nums[col]);
                        
                    }
                    
                }
               
                int sum = 0;
                if (matrix_size == 1)
                {
                    sum += matrix[0,0];
                }
                
                for (int i = matrix_size - 2; i >= 0; i--)
                {
                    for (int l = 0; l <= i; l++)
                    {
                        int max = findMax(matrix[i + 1, l], matrix[i + 1, l + 1]);
                        matrix[i,l] += max;
                    }
                }
                Console.WriteLine(matrix[0,0]);
            }

            Console.ReadLine();
        }

        static int findMax(int x,int y)
        {
            return x > y ? x : y;
        }
    }
}
