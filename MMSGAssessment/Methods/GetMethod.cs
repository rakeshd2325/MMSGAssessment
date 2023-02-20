using MMSGAssessment.Utils;
using System.Net.Http;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using Xunit;
using Newtonsoft.Json;


namespace MMSGAssessment.Methods
{
    public class GetMethod
    {

        HttpClient httpClient;
        HttpResponseMessage response;
        public string responseBody { get; set; }
        public bool responseCode { get; set; }
        private readonly ISpecFlowOutputHelper _OutputHelper;
        public GetMethod(ScenarioContext scenarioContext,ISpecFlowOutputHelper _OutputHelper)
        {
            httpClient = new HttpClient();
            this._OutputHelper = _OutputHelper;
        }

        public async Task SendGetRequest(ScenarioContext scenarioContext,string uri)
        {
            response = await httpClient.GetAsync(uri);
            responseBody = await response.Content.ReadAsStringAsync();
            responseCode = response.IsSuccessStatusCode;
            scenarioContext["response_body"] = responseBody;
            scenarioContext["response_code"] = responseCode;
            _OutputHelper.WriteLine("Response Code:" + scenarioContext["response_code"]);
            _OutputHelper.WriteLine("Response Body:" + responseBody);
        }

        public void verifyStatusCodeAsync(ScenarioContext scenarioContext)
        {
            bool actualStatuResponsescode = (bool)scenarioContext["response_code"];
            Assert.True(actualStatuResponsescode);
        }

        public void verifyNamesInResponseBody(ScenarioContext scenarioContext,string firstname,string lastname)
        {
            string responsebody = (string)scenarioContext["response_body"];
            var deserializedData = JsonConvert.DeserializeObject<DataModel>(responsebody);
            Assert.Contains(deserializedData.data, item => item.first_name == firstname);
            Assert.Contains(deserializedData.data, item => item.last_name == lastname);
        }
        
          public void verifyUnSuccessfulStatusCode(ScenarioContext scenarioContext)
        {
            bool actualStatuResponsescode = (bool)scenarioContext["response_code"];
            Assert.False(actualStatuResponsescode);
        }

    }
}
