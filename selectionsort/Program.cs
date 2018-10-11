using System;

namespace selectionsort{

    class Program {

        static void Main(string[] args) {

            int[] original = {3, 1, 5, 9, 11, 8 };
            for (int i=0;i<original.Length;i++ ){
                Console.Write(original[i] + ", ");
            }
            int[] after = sort(original);
            Console.WriteLine("");
            for (int i=0;i<after.Length;i++ ){
                Console.Write(after[i] + ", ");
            }
        }

        static int[] sort(int[] before) {
            
            for (int i=0;i<before.Length;i++)
            {
                int smallest = before[i];
                for (int j= i+1;j<before.Length;j++)
                {
                    if (before[j] < smallest)
                    {
                        smallest = before[j];
                        before[j] = before[i];
                        before[i] = smallest;
                    }
                }
            }
            return before;
        }
    }
}