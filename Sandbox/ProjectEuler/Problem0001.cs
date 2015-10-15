using System;

namespace Sandbox
{
	/// <summary>
	/// https://projecteuler.net/problem=1 
	/// If we list all the natural numbers below 10 that are multiples of 3 or 5, 
	/// we get 3, 5, 6 and 9. The sum of these multiples is 23.
	/// Find the sum of all the multiples of 3 or 5 below 1000.
	/// </summary>
	public class Problem0001 : IEuler
	{
		public Problem0001()
		{
		}

		public string Run()
		{
			int sum = 0;
			for (int i = 1; i < 1000; i++)
			{
				if (i % 3 == 0)
				{
					sum += i;
				}
				else if (i % 5 == 0)
				{
					sum += i;
				}
			}
			Console.WriteLine(sum);
			return sum.ToString();
		}
	}
}

