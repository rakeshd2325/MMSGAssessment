using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using MMSGAssessment.Methods;

namespace MMSGAssessment.StepsDefinitions
{
    [Binding]
    public class POSTRequest
    {
        POSTMethod postMethod;
        private ScenarioContext scenarioContext;
        private readonly ISpecFlowOutputHelper _OutputHelper;
        public POSTRequest(ScenarioContext scenarioContext, ISpecFlowOutputHelper _OutputHelper)
        {
            this.scenarioContext = scenarioContext;
            this._OutputHelper = _OutputHelper;
            postMethod = new POSTMethod(scenarioContext, _OutputHelper);

        }

        [Given(@"the user sends a POST request with URI as ""(.*)"" with body as ""(.*)"" and ""(.*)""")]
        public async Task GivenTheUserSendsAPOSTRequestWithURIAs(string uri,string name,string job)
        {
            await postMethod.SendPostRequest(scenarioContext, uri,name,job);
        }

        [Then(@"the user verifies the POST request is successful with 201 response code")]
        public void ThenTheUserVerifiesTheRequestIsSuccessfullWithResponseCode()
        {
            postMethod.verifyStatusCodeAsync(scenarioContext);
        }

        [Then(@"the user verifies id attribute is displayed in the response")]
        public void ThenTheUserVerifiesIdAttributeIsDisplayedInTheResponse()
        {
            postMethod.verifyIdAttributeResponseBody(scenarioContext);
        }

        [Given(@"send POST request with URI as ""(.*)"" with invalid type name attribute in the body (.*) and ""(.*)""")]
        public async Task GivenSendPOSTRequestWithURIAsWithInvalidTypeNameAttributeInTheBodyAnd(string uri, string name, string job)
        {
            await postMethod.SendPostRequest(scenarioContext, uri, name, job);
        }

        [Then(@"the user verifies invalid type ""(.*)"" is received in response")]
        public void ThenTheUserVerifiesInvalidTypeIsReceivedInResponse(string InvalidType)
        {
            postMethod.verifyInvlidTypeMessage(scenarioContext, InvalidType);
        }

    }
}
