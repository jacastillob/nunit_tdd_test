using System;
using System.Collections.Generic;

public static class Program
{
	public static int NonConstructibleChange(int[] coins)
	{   //sort array
		Array.Sort(coins);


		int change = 0;
		// O(n)
        foreach (int coin in coins)
        {
			if (coin > change + 1) { 
				return change + 1;
			}
			
			change += coin;
        }

		return change+1;
	}
}

