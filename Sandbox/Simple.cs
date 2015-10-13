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


    }
}

