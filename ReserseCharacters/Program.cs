using System;

namespace ReserseCharacters
{
    /*
    Description
    Reverse all but first and last characters of a string.

    Example

    Input : "abcad"
    Output: "aacbd"
    __________________________________

    Input : "a0b c1d"
    Output: "a1c b0d"

     */
    class Program
    {
        static void Main(string[] args)
        {
            String str1 = "abcad";
            Console.WriteLine(str1);
            String str1Reversed = Reversal(str1);
            Console.WriteLine(str1Reversed);

            String str2 = "a0b c1d";
            Console.WriteLine(str2);
            String str2Reversed = Reversal(str2);
            Console.WriteLine(str2Reversed);
        }

        /**
            array: a b c d e
            index: 0 1 2 3 4

            b c d
            

         */
        public static string Reversal(string s)
        {
            Char[] output = new Char[s.Length];
            //not reversing first character
            int startIndex = 1;
            //not reversing last character
            int len, lastIndex;
            len = lastIndex = s.Length-1-1;


            Char[] temp = s.Substring(1, len).ToCharArray();

            string reversed = "";
            output[0] = s.Substring(0, 1).ToCharArray()[0];
            for(int i=startIndex;i<len;i++) {
                for (int j=temp.Length-1;j<0;j--)
                {
                    output[i] = temp[j];
                }
            }
            output[s.Length-1] = s.Substring(lastIndex, 1).ToCharArray()[0];

            reversed = new string(output);
            return reversed;
        }
    }
}
