using System;

namespace Code
{
    public class Sorting
    {
        public static void MergeSort(int[] toBeSorted)
        {
           

            int[] helper = new int[toBeSorted.Length];
            mergesort(toBeSorted, helper, 0, toBeSorted.Length - 1);
            
        }

        public static void mergesort(int[] array, int[] helper, int low, int high)
        {
            if (low < high)
            {
                int mid = (high + low) / 2;
                mergesort(array, helper, low, mid);
                mergesort(array, helper, mid + 1, high);
                merge(array, helper, low, mid, high);
            }
        }
        public static void merge(int[] array, int[] helper, int low, int middle, int high)
        {
            /* Copy both halves into a helper array */
            for (int i = low; i <= high; i++) {
                    helper[i] = array[i];
            }

            int helperLeft = low;
            int helperRight = middle + 1;
            int current = low;
            /* Iterate through helper array. Compare the left and right half, copying back
             * the smaller element from the two halves into the original array. */
             while (helperLeft <= middle && helperRight <= high)
             {
                 if (helper[helperLeft] <= helper[helperRight])
                 {
                            array[current] = helper[helperLeft];
                            helperLeft++;
                 } else
                 { // If right element is smaller than left element
                            array[current] = helper[helperRight];
                            helperRight++;
                 }
                        current++;
             }

             /* Copy the rest of the left side of the array into the target array */
             int remaining = middle - helperLeft;
             for (int i = 0; i <= remaining; i++)
             {
                 array[current + i] = helper[helperLeft + i];
             }
        }

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
