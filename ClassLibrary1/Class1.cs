using System;
using System.Linq;



	public class Solution
	{
		public static int MinimumNumber(int[] numbers)
		{
			int sum = numbers.Sum();
		    int count = 0;
		    int countNotPrime = 0;
		    int countFirst = 0;
		    bool flag = false;
		for (int i = 2; i < (sum / 2) + 1; i++)
		{
			if (sum % i == 0)
			{
				countFirst++;
			}
		}
		if (countFirst == 0)
		{
			flag = true;
		}
		while (flag==false)
        {
			sum += 1;
			count++;
			for (int i = 2; i < (sum / 2) + 1; i++)
			{
				if (sum % i == 0)
				{
					countNotPrime++;
				}
			}
			if(countNotPrime == 0)
            {
				flag = true;
            }
		}
		return count;
		}
	}

