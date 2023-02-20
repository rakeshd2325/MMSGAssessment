using System;
using MMSGAssessment.Utils;
using System.Net.Http;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using Xunit;
using Newtonsoft.Json;
using System.Text;

namespace MMSGAssessment.Methods
{
    class PutPatchMethod
    {
        HttpClient httpClient;
        HttpResponseMessage response;
        HttpRequestMessage request;
        public string responseBody { get; set; }
        public bool responseCode { get; set; }
        private readonly ISpecFlowOutputHelper _OutputHelper;
        public PutPatchMethod(ScenarioContext scenarioContext, ISpecFlowOutputHelper _OutputHelper)
        {
            httpClient = new HttpClient();
            this._OutputHelper = _OutputHelper;
        }
        public async Task SendPutORPatchRequest(ScenarioContext scenarioContext, string requestType, string uri, string name, string job)
        {
            switch (requestType){ 
            case "PUT":
                 request = new HttpRequestMessage(HttpMethod.Put, uri);
                break;
            case "PATCH":
                 request = new HttpRequestMessage(HttpMethod.Patch, uri);
                break;
             default:
                    throw new Exception("Send PUT or PATCH Request only");
                    break;
            }
            POSTDataModel postData = new POSTDataModel();
            postData.name = name;
            postData.job = job;
            string data = JsonConvert.SerializeObject(postData);
            var contentdata = new StringContent(data, Encoding.UTF8, "application/json");
            request.Content = contentdata;
            response = await httpClient.SendAsync(request);
            responseBody = await response.Content.ReadAsStringAsync();
            responseCode = response.IsSuccessStatusCode;
            scenarioContext["response_body"] = responseBody;
            scenarioContext["response_code"] = responseCode;
            _OutputHelper.WriteLine("Response Code:" + scenarioContext["response_code"]);
            _OutputHelper.WriteLine("ResponseBody:" + responseBody);
        }

        public void verifyStatusCodeAsync(ScenarioContext scenarioContext)
        { 
            bool actualStatuResponsescode = (bool)scenarioContext["response_code"];
            Assert.True(actualStatuResponsescode);
        }
        public void verifyUpdatedJobInResponseBody(ScenarioContext scenarioContext,string job)
        {
            string responsebody = (string)scenarioContext["response_body"];
            var deserializedData = JsonConvert.DeserializeObject<Rootobject>(responsebody);
            Assert.True(deserializedData.job.Equals(job));
        }
    }
}
