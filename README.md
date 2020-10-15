#Logging from summary of method

1. Install nuget package [<img src="https://raw.githubusercontent.com/pamidur/aspect-injector/master/package.png" width="24"/> AspectInjector](https://github.com/pamidur/aspect-injector) 
2. Install nuget package [<img src="https://raw.githubusercontent.com/RicoSuter/Namotion.Reflection/master/assets/Icon.png" width="24"> Namotion.Reflection](https://github.com/RicoSuter/Namotion.Reflection) for read summary


3. Go to `Property Project` -> `Build`
Check `XML documentation file`


4. Create aspect attribute

```csharp
    [Aspect(Scope.Global)]
    [Injection(typeof(LogCall))]
    public class LogCall : Attribute
    {
        [Advice(Kind.Before, Targets = Target.Method)]
        public void TraceBegin([Argument(Source.Metadata)] MethodBase meta)
        {
            var methodSummer = meta.GetXmlDocsSummary();
            Console.WriteLine($"Begin {methodSummer}");
        }

        [Advice(Kind.After, Targets = Target.Method)]
        public void TraceEnd([Argument(Source.Metadata)] MethodBase meta)
        {
            var methodSummer = meta.GetXmlDocsSummary();
            Console.WriteLine($"End {methodSummer}");
        }
    }
```

To use logging, you just need to hang the attribute on the class

```csharp
    /// <summary />
    [LogCall]
    public class TestClass
    {
        /// <summary>
        /// method GetValue
        /// </summary>
        /// <returns>int value</returns>
        public int GetValue()
        {
            return 100500;
        }

        /// <summary>
        /// method Show
        /// </summary>
        public void Show()
        {

        }
    }
```