using Reqnroll;

namespace ReqnrollAfterScenarioBug.Steps;

[Binding]
public class TestSteps
{
    [When("I finish scenario with inconclusive status")]
    public void WhenIFinishScenarioWithInconclusiveStatus()
    {
        Assert.Inconclusive($"Inconclusive scenario{Environment.NewLine}");
    }

    [When("I call normal step")]
    public void WhenICallNormalStep()
    {
        Console.WriteLine("Log: Normal step");
    }
}