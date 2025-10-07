# ReqnrollAfterScenarioBug

## Steps to reproduce

Execute scenarios in `Features\Tests.feature`

Watch test execution console:

- Scenario Call_Normal_Step : Before scenario & after scenario hooks are executed
- Scenario Call_Inconclusive_Step : Only before scenario hook is executed, after scenario is never called
