using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeDailyChallenges
{
    internal class _1502_CanMakeArithmeticProgressionFromSequence
    {
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            /* https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence/
             * 
             * Sort the array. Calculate the common difference and compare adjacent elements. 
             * If any difference does not match, return False. 
             * 
             * Time complexity: O(N log N), where N is the size of the array.
             */
            Array.Sort(arr);
            int diff = arr[1] - arr[0];
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] != diff)
                    return false;
            }
            return true;
        }
    }
}
