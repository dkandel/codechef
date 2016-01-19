using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] inputs = new int[input];
            for (int i = 0; i < input; i++)
            {
                inputs[i] = int.Parse(Console.ReadLine());
            }
            //int[] res = new int[input3.Length];
            Sorting sort = new Sorting();
            var res = sort.MergeSort(inputs);
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
    public class Sorting
    {
        private int[] array;
        private int[] tempMergArr;
        private int length;

        #region Merge Sort

        public int[] MergeSort(int[] input)
        {
            this.array = input;
            this.length = input.Length;
            this.tempMergArr = new int[length];

            if (input.Length <= 1)
            {
                return input;
            }
            else
            {
                return doMergeSort(0, length - 1);
            }

        }

        public int[] doMergeSort(int left, int right)
        {
            if (right > left)
            {
                int mid = left + (right - left) / 2;
                doMergeSort(left, mid);
                doMergeSort(mid + 1, right);
                return Merge(left, mid, right);

            }
            else
            {
                return null;
            }


        }

        public int[] Merge(int left, int mid, int right)
        {
            for (int a = left; a <= right; a++)
            {
                tempMergArr[a] = array[a];
            }

            int i = left;
            int j = mid + 1;
            int k = left;

            while (i <= mid && j <= right)
            {
                array[k++] = (array[j] < tempMergArr[i]) ? array[j++] : tempMergArr[i++];
            }
            while (i <= mid)
            {
                array[k++] = tempMergArr[i++];
            }

            return array;
        }
        #endregion

    }
}
