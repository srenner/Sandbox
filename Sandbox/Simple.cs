using System;

namespace Sandbox
{
    public static class Simple
    {
        /* http://www.thousandtyone.com/blog/EasierThanFizzBuzzWhyCantProgrammersPrint100To1.aspx
         * seeing what the fuss is about with this article 
         * update: took less than a minute (???) */ 
        public static void Print100to1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(100 - i);
            }
        }

        /* If the same reference was passed into both parameters, x and y are the same
         * http://www.thomaslevesque.com/2015/03/10/c-puzzle-1/
         */ 
        public static void OutParameterTest1(out int x, out int y)
		{
			x = 42;
			y = 123;
			Console.WriteLine("x=" + x);
			Console.WriteLine("y=" + y);
			Console.WriteLine(x == y);
		}

    }
}

