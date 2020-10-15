using AspectInjector.Broker;
using System;
using System.Reflection;

namespace LoggingFromSummaryOfMethod.Loggers
{
    /// <summary />
    [Aspect(Scope.Global)]
    [Injection(typeof(LogMethodName))]
    public class LogMethodName : Attribute
    {
        /// <summary />
        [Advice(Kind.Before, Targets = Target.Method)]
        public void TraceBegin([Argument(Source.Metadata)] MethodBase meta,
            [Argument(Source.Type)] Type owner)
        {
            var methodName = meta.Name;
            var className = owner.Name;
            Console.WriteLine($"Begin method {className}.{methodName}");
        }

        /// <summary />
        [Advice(Kind.After, Targets = Target.Method)]
        public void TraceEnd([Argument(Source.Metadata)] MethodBase meta,
            [Argument(Source.Type)] Type owner)
        {
            var methodName = meta.Name;
            var className = owner.Name;
            Console.WriteLine($"End method {className}.{methodName}");
        }
    }
}
