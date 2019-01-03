using StoryBox.Core.Domain;
using System;

namespace StoryBox
{
    class Program 
    {
        static void Main(string[] args)
        {
            var app = new StoryBox.Cli.AppContext();
            app.Start();
         
            Console.ReadKey();
        }
    }
}
