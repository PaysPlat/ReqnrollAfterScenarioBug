using Reqnroll;

namespace ReqnrollAfterScenarioBug.Steps;

[Binding]
public class TestSteps
{
    [When("I call normal step")]
    public void WhenICallNormalStep()
    {
        Console.WriteLine("Log: Normal step");
    }

    [When("I finish scenario with '{ScenarioStatus}' status")]
    public void WhenIFinishScenarioWithStatus(ScenarioStatus status)
    {
        GetScenarioStatusAction(status)();
    }

    private static Action GetScenarioStatusAction(ScenarioStatus scenarioStatus)
    {
        return scenarioStatus switch
        {
            ScenarioStatus.Success => Assert.Pass,
            ScenarioStatus.Failed => Assert.Fail,
            ScenarioStatus.Inconclusive => Assert.Inconclusive,
            ScenarioStatus.Skipped => Assert.Ignore,
            _ => throw new ArgumentOutOfRangeException(nameof(scenarioStatus), scenarioStatus, null)
        };
    }
}

public enum ScenarioStatus
{
    Success,
    Failed,
    Inconclusive,
    Skipped,
}