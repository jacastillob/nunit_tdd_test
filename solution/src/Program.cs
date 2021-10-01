using System;
using System.Collections.Generic;

public class Program
{
	public static int[] algorithm(int[] array, int targetSum)
	{
		// Write your code here.
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
}

