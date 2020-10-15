using System;

namespace LoggingFromSummaryOfMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start app");
            var a = new TestClass();
            a.GetValue();
            a.Show();
            Console.WriteLine("End app");
        }
    }
}
