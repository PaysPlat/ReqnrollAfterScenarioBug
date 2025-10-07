Feature: Test

    Scenario: Call_Normal_Step
        When I call normal step

    Scenario: End_Scenario_With_Status
        When I finish scenario with '<Status>' status

    Examples:
      | Status       |
      | Success      |
      | Failed       |
      | Inconclusive |
      | Skipped      |