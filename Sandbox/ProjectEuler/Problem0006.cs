using System;

namespace Sandbox
{
	public class Problem0006 : IEuler
	{
		public Problem0006()
		{
		}

		public string Run()
		{
			long squareOfSum = 0;
			for(int i = 1; i <= 100; i++)
			{
				squareOfSum = squareOfSum + i;
			}
			squareOfSum = squareOfSum * squareOfSum;

			long sumOfSquare = 0;
			for (int i = 1; i <= 100; i++)
			{
				sumOfSquare = sumOfSquare + i * i;
			}

			//Console.WriteLine(squareOfSum);

			//Console.WriteLine(sumOfSquare);


			return (squareOfSum - sumOfSquare).ToString();
		}
	}
}

