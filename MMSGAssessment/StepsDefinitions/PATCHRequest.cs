using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using MMSGAssessment.Methods;

namespace MMSGAssessment.StepsDefinitions
{
    [Binding]
    class PATCHRequest
    {
        PutPatchMethod putpatchMethod;
        private ScenarioContext scenarioContext;
        private readonly ISpecFlowOutputHelper _OutputHelper;
        public PATCHRequest(ScenarioContext scenarioContext, ISpecFlowOutputHelper _OutputHelper)
        {
            this.scenarioContext = scenarioContext;
            this._OutputHelper = _OutputHelper;
            putpatchMethod = new PutPatchMethod(scenarioContext, _OutputHelper);

        }

        [Given(@"the user sends a PATCH request with URI as ""(.*)"" with body as ""(.*)"" and new job as ""(.*)""")]
        public async Task GivenTheUserSendsAPUTRequestWithURIAsWithBodyAsAndNewJobAs(string uri, string name, string job)
        {
            string requestType = "PATCH";
            await putpatchMethod.SendPutORPatchRequest(scenarioContext, requestType, uri, name, job);
        }

    }
}

