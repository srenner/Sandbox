using System;

namespace Sandbox
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			//YesterdaysStocks ys = new YesterdaysStocks();
			//ys.Run(); 

			//Simple.Print100to1();
            
            //int x = 1;
			//Simple.OutParameterTest1(out x, out x);
            
			var before = DateTime.Now;
            
			var euler = new Problem0005();
			Console.WriteLine(euler.Run());
            
			var after = DateTime.Now;
            
			Console.WriteLine((after - before).TotalSeconds);
		}

        
	}
}
