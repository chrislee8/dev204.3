using System;

namespace AvgListNumbers
{
    class Program
    {
        public static void Main(String[] args)
        {
            int avg;
            int[] array1 = new int[]
            {
                1,
                3,
                1,
                1
            };
            Console.WriteLine("Input : [1, 3, 1, 1]");
            avg = Average(array1);
            Console.WriteLine("Output: {0}", avg);

            int[] array2 = new int[]
            {
                -3, 2
            };
            Console.WriteLine("Input : [-3,2]");
            avg = Average(array2);
            Console.WriteLine("Output: {0}", avg);

            int[] array3 = new int[]
            {
                -2, 4, -1, 6
            };
            Console.WriteLine("Input : [-2,4,-1,6]");
            avg = Average(array3);
            Console.WriteLine("Output: {0}", avg);
        }

        public static int Average(int[] a)
        {
            int sum = 0;
            int avg = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("sum, {0}", sum);
            int quotation = sum / a.Length;
            Console.WriteLine("quotation:, {0}", quotation);
            int remainder = sum % a.Length;
            Console.WriteLine("remainder: {0}", remainder);
            double faction = (double)remainder / a.Length;
            Console.WriteLine("faction, {0}", faction);
            if (faction >= 0.5)
            {
                avg = quotation + 1;
            }

            return avg;
        }
    }
}