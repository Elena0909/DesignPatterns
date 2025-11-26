using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern;

public class Singleton
{
    private static int Counter = 0;

    private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

    public static Singleton GetInstance()
    {
        return instance.Value;
    }

    private Singleton()
    {
        Counter++;
        Console.WriteLine($"Counter Value {Counter.ToString()}");
    }

    public void PrintDetails(string message)
    {
        Console.WriteLine(message);
    }
}
