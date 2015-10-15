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
            
			var problem3 = new Problem0003();
			System.Windows.Forms.Clipboard.Clear();
            System.Windows.Forms.Clipboard.SetText(problem3.Run());
		}

        
	}
}
