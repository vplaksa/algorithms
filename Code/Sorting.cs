using System;

namespace Code
{
    public class Sorting
    {
        //public static int[] MergeSort()
        //{ }

        public static int[] Merge(int[] arr1, int[] arr2)
        {
            if (arr1 == null)
                arr1 = new int[0];

            if (arr2 == null)
                arr2 = new int[0];

            var resLen = arr1.Length + arr2.Length;

            var resArr = new int[resLen];

            int i = 0, j = 0;
            for (int k = 0; k < resLen; k++)
            {
                if (i + 1 > arr1.Length)
                {
                    resArr[k] = arr2[j]; //if 1st index is outside of the bounds
                    //just take value from arr2 with its current index. it should be valid
                    j++;
                }
                else if (j + 1 > arr2.Length)
                {
                    resArr[k] = arr1[i];
                    i++;
                }
                else if (arr1[i] < arr2[j])
                {
                    resArr[k] = arr1[i]; //use value from 1st array by "current" index
                    i++; //increment index. index j stays the same, value from arr2[j] will
                    //be used at the next step
                }
                else
                {
                    resArr[k] = arr2[j];
                    j++;
                }
            }

            return resArr;

        }
    }
}
