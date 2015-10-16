using System;

namespace Sandbox
{
	public class Problem0005 : IEuler
	{
		public Problem0005()
		{
		}

		public string Run()
		{
			for (int candidate = 2520; candidate <= Int32.MaxValue; candidate = candidate + 10)
			{
				bool victory = true;
				for (int denominator = 2; denominator <= 20; denominator++)
				{
					if (candidate % denominator > 0)
					{
						victory = false;
						break;
					}
				}
				if (victory)
				{
					return candidate.ToString();
				}
			}
			return "0";
		}
	}
}

