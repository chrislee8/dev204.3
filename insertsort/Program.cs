using System;

namespace insertsort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] original = {0, 3, 9, 2, 1, 7, 5};
            for (int i=0;i<original.Length;i++)
            {
                Console.Write(original[i] + ", ");
            }
            Console.WriteLine("");
            int[] after = insertsort(original);
            for (int i=0;i<after.Length;i++)
            {
                Console.Write(after[i] + ", ");
            }
        }

        static int[] insertsort(int[] before)
        {
            for (int i=1;i<before.Length;i++)
            {
                for (int j=i;j>0;j--)
                {
                    if (before[j] < before[j-1])
                    {
                        int temp = before[j];
                        before[j] = before[j-1];
                        before[j-1] = temp;
                    }
                }

            }
            return before;
        }
    }
}
