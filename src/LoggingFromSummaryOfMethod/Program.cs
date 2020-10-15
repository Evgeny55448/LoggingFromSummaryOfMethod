using LoggingFromSummaryOfMethod.Loggers;

namespace LoggingFromSummaryOfMethod
{
    class Program
    {
        [LogMethodName]
        static void Main(string[] args)
        {
            var a = new TestClass();
            a.GetValue();
            a.Show();
        }
    }
}
