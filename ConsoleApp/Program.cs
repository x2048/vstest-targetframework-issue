using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
              new ExampleTest.UnitTest1().Test1();
              Console.WriteLine("All fine :)");
            }
            catch (Exception e)
            {
              Console.WriteLine(e);
            }
        }
    }
}
