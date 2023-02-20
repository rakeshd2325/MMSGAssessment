using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using MMSGAssessment.Methods;

namespace MMSGAssessment.StepsDefinitions
{
    [Binding]
    public class GETRequest
    {
        GetMethod getMethod;
        private ScenarioContext scenarioContext;
        private readonly ISpecFlowOutputHelper _OutputHelper;
        public GETRequest(ScenarioContext scenarioContext, ISpecFlowOutputHelper _OutputHelper)
        {
            this.scenarioContext = scenarioContext;
            this._OutputHelper = _OutputHelper;
            getMethod = new GetMethod(scenarioContext,_OutputHelper);

        }

        [Given(@"the user sends a get request with URI as ""(.*)""")]
        public async Task UserSendsAGetRequestWithURIAs(string uri)
        {
            await getMethod.SendGetRequest(scenarioContext,uri);
        }

        [Then(@"the user verifies the request is successful with 200 response code")]
        public void ThenTheUserVerifiesTheRequestIsSuccessfullWithResponseCode()
        {
            
            getMethod.verifyStatusCodeAsync(scenarioContext);
        }

        [Then(@"the user verifies ""(.*)"" and ""(.*)"" is displayed in the output response")]
        public void ThenTheUserVerifiesAndIsDisplayedInTheOutputResponse(string firstname, string lastname)
        {
            getMethod.verifyNamesInResponseBody(scenarioContext, firstname, lastname);
        }

        [Then(@"the user verifies the request is not successful")]
        public void ThenTheUserVerifiesTheRequestIsNotSuccessfullWithResponseCode()
        {
            getMethod.verifyUnSuccessfulStatusCode(scenarioContext);
        }

    }
}
