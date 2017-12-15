using System;
using System.Threading.Tasks;

namespace CSharp71Demos
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            DefaultsDemo.Show();
            TuplesDemo.Show();
            return await DoAsyncWork();
        }

        private static async Task<int> DoAsyncWork()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            return 5;
        }
    }
}
