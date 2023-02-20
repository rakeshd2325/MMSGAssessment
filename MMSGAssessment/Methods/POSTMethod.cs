using MMSGAssessment.Utils;
using System.Net.Http;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;
using Xunit;
using Newtonsoft.Json;
using System.Text;
using System;

namespace MMSGAssessment.Methods
{
 
    class POSTMethod
    {
        HttpClient httpClient;
        HttpResponseMessage response;
        HttpRequestMessage request;
        public string responseBody { get; set; }
        public bool responseCode { get; set; }
        private readonly ISpecFlowOutputHelper _OutputHelper;
        public POSTMethod(ScenarioContext scenarioContext, ISpecFlowOutputHelper _OutputHelper)
        {
            httpClient = new HttpClient();
            this._OutputHelper = _OutputHelper;
        }

        public async Task SendPostRequest(ScenarioContext scenarioContext,string uri, string name, string job) {
            request = new HttpRequestMessage(HttpMethod.Post, uri);
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

        public void verifyIdAttributeResponseBody(ScenarioContext scenarioContext)
        {
            string responsebody = (string)scenarioContext["response_body"];
            var deserializedData = JsonConvert.DeserializeObject<Rootobject>(responsebody);
            Assert.NotNull(deserializedData.id);
            _OutputHelper.WriteLine("ID:" + deserializedData.id.ToString() + "\n" + "CreatedAt:" + deserializedData.createdAt.ToString());
        }

        public void verifyInvlidTypeMessage(ScenarioContext scenarioContext,string Invalidtype)
        {
            string responsebody = (string)scenarioContext["response_body"];
            var deserializedData = JsonConvert.DeserializeObject<Rootobject>(responsebody);
            if (Invalidtype.Equals("name")){
                Assert.Contains("InvalidTypename", deserializedData.name.ToString());
            }
            else if (Invalidtype.Equals("job"))
            {
                Assert.Contains("InvalidTypename", deserializedData.name.ToString());
                Assert.Contains("job", deserializedData.job.ToString());
            }
            else
            {
                throw new Exception("Invalid type not declared");
            }
        }
    }
}
