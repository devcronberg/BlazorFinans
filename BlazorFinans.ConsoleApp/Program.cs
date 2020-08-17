using BlazorFinans.Kerne;
using System;
using System.Threading.Tasks;

namespace BlazorFinans.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var data = await MoraRente.HentRente();
            //TestYdelse();    
        }

        private static void TestYdelse()
        {
            var res = BlazorFinans.Kerne.FinansielleBeregninger.MånedligYdelse(.1, 10, 100000);
            Console.WriteLine(res);
        }
    }
}
