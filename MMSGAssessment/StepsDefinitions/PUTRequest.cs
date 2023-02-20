using MMSGAssessment.Methods;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace MMSGAssessment.StepsDefinitions
{
    [Binding]
    public class PUTRequest
    {
        PutPatchMethod putpatchMethod;
        private ScenarioContext scenarioContext;
        private readonly ISpecFlowOutputHelper _OutputHelper;
        public PUTRequest(ScenarioContext scenarioContext, ISpecFlowOutputHelper _OutputHelper)
        {
            this.scenarioContext = scenarioContext;
            this._OutputHelper = _OutputHelper;
            putpatchMethod = new PutPatchMethod(scenarioContext, _OutputHelper);

        }

        [Given(@"the user sends a PUT request with URI as ""(.*)"" with body as ""(.*)"" and new job as ""(.*)""")]
        public async Task GivenTheUserSendsAPUTRequestWithURIAsWithBodyAsAndNewJobAs(string uri, string name, string job)
        {
            string requestType = "PUT";
            await putpatchMethod.SendPutORPatchRequest(scenarioContext, requestType, uri, name, job);
        }

        [Then(@"the user verifies the PUT request is successful with 200 response code")]
        [Then(@"the user verifies the PATCH request is successful with 200 response code")]
        public void ThenTheUserVerifiesThePUTRequestIsSuccessfullWithResponseCode()
        {
            putpatchMethod.verifyStatusCodeAsync(scenarioContext);
        }

        [Then(@"the user verifies updated ""(.*)"" in the PUT response")]
        [Then(@"the user verifies updated ""(.*)"" in the PATCH response")]
        public void ThenTheUserVerifiesUpdatedJobInTheResponse(string job)
        {
            putpatchMethod.verifyUpdatedJobInResponseBody(scenarioContext, job);
        }
    }
}
