using Volo.Abp.DependencyInjection;

namespace HelloAbp;

public class HelloWorldService:ITransientDependency
{
    public void Run()
    {
        Console.WriteLine("Hello World!");
    }
}