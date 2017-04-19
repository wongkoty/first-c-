using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String string1 = "This is a string";
            Console.WriteLine(string1);
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            PrintFooToScreen100Times();

            if(keyInfo.KeyChar == 'a')
            {
                Console.WriteLine("That is not a number");
            }
            else
            {
                Console.WriteLine("Did you type {0}", keyInfo.KeyChar.ToString());
            }
        }

        static void PrintFooToScreen()
        {
            Console.WriteLine("foo");
        }
        static void PrintFooToScreen100Times()
        {
            for (var i = 0; i < 100; i++)
            {
                PrintFooToScreen();
;           }
        }
    }
}