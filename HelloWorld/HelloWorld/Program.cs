using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimeOffset currentTime = DateTimeOffset.Now;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Current time is: {0}", currentTime);
        }
    }
}
