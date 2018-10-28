using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Code
{
    public class Anagram
    {
        public static bool IsAnagram(string s1, string s2)
        {
            var charArray1 = s1.ToCharArray();
            var charArray2 = s2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            return charArray1.SequenceEqual(charArray2); ;
        }

        public static bool IsAnagramBuffer(string s1, string s2)
        {
            var charArray1 = s1.ToCharArray();
            var charArray2 = s2.ToCharArray();

            if (charArray1.Length != charArray2.Length)
                return false; //obvious

            

            // bool[] checkbuffer = new bool[charArray1.Length];

            var r1 = Fill(charArray1, charArray2);//, checkbuffer);
            var r2 = Fill(charArray2, charArray1);//, checkbuffer);

            //такой учет не прокатывает


            return true;
        }

        private static bool Fill(char[] a1, char[] a2)//, bool[] buf)
        {
            int l = a1.Length;
            for (int i = 0; i < l; i++)
            {
                var current = a1[i];
                var oneTrue = false;
                for (int j = 0; j < l; j++)
                {
                    if (a2[j] == current)
                    {
                       // buf[i] = true;
                        oneTrue = true;
                    }
                    //else
                    //    buf[i] = false;
                }
                if (oneTrue == false)
                {
                   // buf[i] = false;
                    return false;
                }
            }
            return true;
        }
    }
}
