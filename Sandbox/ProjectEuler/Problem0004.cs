using System;
using System.Text;

namespace Sandbox
{
	public class Problem0004 : IEuler
	{
		public Problem0004()
		{
		}

		//todo could be more efficient
		private bool IsPalindrome(string input)
		{
			string copy = input;
			StringBuilder reversed = new StringBuilder();
			for (int i = copy.Length -1; i >=0; i--)
			{
				reversed.Append(copy[i]);
			}
			return input == reversed.ToString();
		}

		public string Run()
		{
			int max = 0;
			for (int multiplier1 = 999; multiplier1 >= 500; multiplier1--)
			{
				for (int multiplier2 = 999; multiplier2 >= 100; multiplier2--)
				{
					int product = multiplier1 * multiplier2;
					if (IsPalindrome((product).ToString()))
					{
						if (product > max)
						{
							max = product;
						}
					}
				}

			}
			return max.ToString();
		}
	}
}

