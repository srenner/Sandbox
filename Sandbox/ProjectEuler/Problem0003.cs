using System;

namespace Sandbox
{
	/// <summary>
	/// The prime factors of 13195 are 5, 7, 13 and 29.
	/// What is the largest prime factor of the number 600851475143 ?
	/// </summary>
	public class Problem0003 : IEuler
	{

		public Problem0003()
		{
		}

		public string Run()
		{
			long bigun = 600851475143;
			//long bigun = 13195;
			long half = bigun / 2;

			for (long i = 2; i <= half; i++)
			{
				if (bigun % i == 0)
				{
					//check for prime
					bool isPrime = true;
					for (long j = 3; j < (i/2); j++)
					{
						if (i % j == 0)
						{
							isPrime = false;
							break;
						}
					}

					if (isPrime)
					{
						Console.WriteLine(i);
					}
				}
			}
		

			return "needs a major refactor but the last WriteLine is the correct answer";
		}
	}
}

