using System;

namespace bubblesort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] original = {1, 6, 3, 7, 21, 2};
			Console.Write("Before: ");
			for (int i=0;i<original.Length;i++) {
				Console.Write(original[i].ToString() + ", ");
			}
			Console.WriteLine("");
			int[] sorted = bubblesort(original);
			Console.Write("After: ");
			for (int i=0;i<sorted.Length;i++) {
				Console.Write(sorted[i].ToString() + ", ");
			}
		}

		static int[] bubblesort(int[] beforesort)
		{
			int[] aftersort = beforesort;
			bool swapped;
			int count = 0;
			do
			{
				swapped = false;
				for (int j=0; j<aftersort.Length-1; j++)
				{
					count++;
					if (beforesort[j] > beforesort[j+1])
					{
						int temp = beforesort[j+1];
						beforesort[j+1] = beforesort[j];
						beforesort[j] = temp;
						swapped = true;
					}
				}
			} while (swapped == true);
			Console.WriteLine(count + " comparison done.");
			return aftersort;
		}

	}
}
