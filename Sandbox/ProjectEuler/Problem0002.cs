using System;
using System.Collections.Generic;

namespace Sandbox
{
	/// <summary>
	/// https://projecteuler.net/problem=2
	/// Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
	/// By starting with 1 and 2, the first 10 terms will be:
	///	1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
	/// By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
	/// find the sum of the even-valued terms.
	/// </summary>
	public class Problem0002 : IEuler
	{
		public Problem0002()
		{
		}

		public string Run()
		{
			int sum = 0;
			int secondMostRecent = 0;
			int mostRecent = 1;
			//Console.WriteLine(mostRecent);
			int next = 2;

			do
			{
				secondMostRecent = mostRecent;
				mostRecent = next;
				//Console.WriteLine(mostRecent);
				if (mostRecent % 2 == 0)
				{
					sum += mostRecent;
				}
			}
			while((next = secondMostRecent + mostRecent) < 4000000);


			Console.WriteLine(sum.ToString());
			return sum.ToString();

		}

	}
}

