using System;

namespace BlazorFinans.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestYdelse();    
        }

        private static void TestYdelse()
        {
            var res = BlazorFinans.Kerne.FinansielleBeregninger.MånedligYdelse(.1, 10, 100000);
            Console.WriteLine(res);
        }
    }
}
