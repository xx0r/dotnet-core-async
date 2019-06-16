namespace DotNetCoreAsync.Console
{
    using System;
    using System.Threading.Tasks;

    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            await MainAsync();

            Console.WriteLine($"After {nameof(MainAsync)}");

            Console.ReadLine();
        }

        private static async Task MainAsync()
        {
            Console.WriteLine($"{nameof(MainAsync)}");

        }


    }
}