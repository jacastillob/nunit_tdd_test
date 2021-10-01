using System;
using System.Collections.Generic;
using System.Linq;

namespace algo.src.questions
{
    public  static class ProgramCompleted
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            List<int> test = new List<int>();
            test[0] = 1;
            
            int index = test.FindIndex(x=> x==1);
            HashSet<int> nums = new HashSet<int>();
            
            foreach (int num in array)
            {
                int potential = targetSum - num;
                if (nums.Contains(potential))
                {
                    return new int[] { potential, num };
                }
                else
                {
                    nums.Add(num);
                }
            }

            return new int[0];
        }

        //O(n ^2)
    public static bool IsValidSubsequence(List<int> array, List<int> sequence)
    {
        // Write your code here.
        int index = 0;
        int matches = 0;
            // O (n) time
            foreach (int item in sequence)
        {
             // O (n) time
            int currentIndex = array.FindIndex(x => x == item);
            if (currentIndex > index)
            {
                index = currentIndex;
                matches++;
            }
            Console.WriteLine("iteration" + item);
        }
        return (index == sequence.Count-1);
    }

        public static bool IsValidSubsequenceBetterOn(List<int> array, List<int> sequence)
        {
            // Write your code here.
            int seqIndx = 0;
            foreach (int val in array)
            {
                if (seqIndx == sequence.Count)
                {
                    string test = "test";
                    break;
                }
                if (sequence[seqIndx]==val)
                {
                    seqIndx++;
                }
            }
            return (seqIndx == sequence.Count);
        }
    }
}
