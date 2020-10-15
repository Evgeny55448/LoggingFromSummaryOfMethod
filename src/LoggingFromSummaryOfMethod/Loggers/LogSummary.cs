using AspectInjector.Broker;
using Namotion.Reflection;
using System;
using System.Reflection;

namespace LoggingFromSummaryOfMethod.Loggers
{
    /// <summary />
    [Aspect(Scope.Global)]
    [Injection(typeof(LogSummary))]
    public class LogSummary : Attribute
    {
        /// <summary />
        [Advice(Kind.Before, Targets = Target.Method)]
        public void TraceBegin([Argument(Source.Metadata)] MethodBase meta)
        {
            var methodSummer = meta.GetXmlDocsSummary();
            Console.WriteLine($"Begin {methodSummer}");
        }

        /// <summary />
        [Advice(Kind.After, Targets = Target.Method)]
        public void TraceEnd([Argument(Source.Metadata)] MethodBase meta)
        {
            var methodSummer = meta.GetXmlDocsSummary();
            Console.WriteLine($"End {methodSummer}");
        }
    }
}
