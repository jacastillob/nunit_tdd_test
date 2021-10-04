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

        
        /// <summary>
        /// Given two non empty arrays of integers,write a function that determines wether the second array is a subsequence of the first one
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sequence"></param>
        /// <returns></returns>
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            int seqIndx = 0;
            //O(n)
            foreach (int val in array)
            {
                if (seqIndx == sequence.Count)
                {
                    break;
                }
                if (sequence[seqIndx]==val)
                {
                    seqIndx++;
                }
            }
            return (seqIndx == sequence.Count);
        }

      /// <summary>
      /// This function throw an exception to see how Nunit reacts to handle it
      /// </summary>
      /// <param name="sum"></param>
      /// <returns></returns>
        public static int breakingAction(int sum)
        {
            return sum / 0;
        }

        public static int[] SortedSquaredArray(int[] array)
        {
            int[] sortedSquares = new int[array.Length];
            // Write your code here.
            int smallerValueIndx = 0;
            int largerValueIndx = array.Length - 1;

            for (int indx = array.Length - 1; indx >= 0; indx--)
            {
                int smallerValue = array[smallerValueIndx];
                int largerValue = array[largerValueIndx];

                if (Math.Abs(smallerValue) > Math.Abs(largerValue))
                {
                    sortedSquares[indx] = smallerValue * smallerValue;
                    smallerValueIndx++;
                }
                else
                {
                    sortedSquares[indx] = largerValue * largerValue;
                    largerValueIndx--;
                }
            }
            return sortedSquares;
        }
        public static int NonConstructibleChange(int[] coins)
        {   //sort array
            Array.Sort(coins);
            int change = 0;
            // O(n)
            foreach (int coin in coins)
            {
                if (coin > change + 1)
                {
                    return change + 1;
                }

                change += coin;
            }

            return change + 1;
        }
    }
}
