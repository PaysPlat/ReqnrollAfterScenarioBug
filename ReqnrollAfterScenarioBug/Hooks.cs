using Reqnroll;

namespace ReqnrollAfterScenarioBug;

[Binding]
public static class Hooks
{

    [BeforeScenario]
    private static void BeforeScenario()
    {
        Console.WriteLine("Log: BeforeScenario");
    }

    [AfterScenario]
    private static void AfterScenario()
    {
        Console.WriteLine("Log: AfterScenario");
        
    }
    
}