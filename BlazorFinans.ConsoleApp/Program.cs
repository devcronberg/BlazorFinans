using BlazorFinans.Kerne;

using System;
using System.Threading.Tasks;

namespace BlazorFinans.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await TestHentRente();
            TestYdelse();
        }

        private static async Task TestHentRente()
        {
            var data = await MoraRente.HentRente();
            foreach (var item in data)
            {
                Console.WriteLine(item.Dato + " " + item.Rente);
            }
        }

        private static void TestYdelse()
        {
            var res = BlazorFinans.Kerne.FinansielleBeregninger.MånedligYdelse(.1, 10, 100000);
            Console.WriteLine(res);
        }
    }
}
