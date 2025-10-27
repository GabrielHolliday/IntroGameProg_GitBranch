using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroGameProg_GitBranch
{
    internal class Program
    {
        static async void GreetingMessage()
        {
            Console.WriteLine("mmmm");
            await Task.Delay(1000);
            Console.WriteLine("Good Moring!");
        }
        static void Main(string[] args)
        {
            GreetingMessage();
        }
    }
}
