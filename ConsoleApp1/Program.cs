using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }
        public async static void Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");
        }
        public static void LongTask()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hello");

        }
    }

    class AsyncProgram
    {
        public async static void Method1(int i)
        {
           await Task.Run(new Action(Picture));
            Console.WriteLine("New Thread");
        }
        public static void Picture()
        {
            Thread.Sleep(10000);
            Console.WriteLine("LongTaskFinishes");
        }
        static void Main(string[] args)
        {
            AsyncProgram ap = new AsyncProgram();
            Method1(10);
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }
    }
}