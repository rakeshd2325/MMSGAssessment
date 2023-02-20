using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace MMSGAssessment.Hooks
{
    [Binding]
    public class MyHooks
    {
        private ScenarioContext _scenarioContext;
        private readonly ISpecFlowOutputHelper _OutputHelper;

        public MyHooks(ScenarioContext scenarioContext, ISpecFlowOutputHelper _OutputHelper)
        {
            _scenarioContext = scenarioContext;
            this._OutputHelper = _OutputHelper;
        }

        [BeforeScenario]
        public void SampleBeforeScenario()
        {
            _OutputHelper.WriteLine("Test Title:"+_scenarioContext.ScenarioInfo.Title);
            _OutputHelper.WriteLine("Test Started");
        }

        [AfterScenario]
        public void SampleAfterScenario()
        {
            _OutputHelper.WriteLine("Test Completed");
        }
    }
}
