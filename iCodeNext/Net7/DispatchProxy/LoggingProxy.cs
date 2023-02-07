using System;
using System.Reflection;

namespace iCodeNext.Net7;

public class LoggingProxy<T> : DispatchProxy
{
    private T Target { get; set; }

    public static T SetProxy<T>(T target) where T : class
    {
        var proxy = Create<T, LoggingProxy<T>>() as LoggingProxy<T>;
        proxy.Target = target;
        return proxy as T;
    }

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        Console.WriteLine("Call Proxy");
        return targetMethod.Invoke(Target, args);
    }
}
