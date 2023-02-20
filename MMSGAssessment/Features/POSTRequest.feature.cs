﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MMSGAssessment.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class TestPOSTRestAPIsFeature : object, Xunit.IClassFixture<TestPOSTRestAPIsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "POSTRequest.feature"
#line hidden
        
        public TestPOSTRestAPIsFeature(TestPOSTRestAPIsFeature.FixtureData fixtureData, MMSGAssessment_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Test POST Rest API\'s", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Verify user is created successfully using POST request API")]
        [Xunit.TraitAttribute("FeatureTitle", "Test POST Rest API\'s")]
        [Xunit.TraitAttribute("Description", "Verify user is created successfully using POST request API")]
        [Xunit.TraitAttribute("Category", "API")]
        [Xunit.TraitAttribute("Category", "PositiveTest")]
        [Xunit.InlineDataAttribute("https://reqres.in/api/users", "morpheus", "leader", new string[0])]
        public virtual void VerifyUserIsCreatedSuccessfullyUsingPOSTRequestAPI(string uRI, string name, string job, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "API",
                    "PositiveTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("URI", uRI);
            argumentsOfScenario.Add("name", name);
            argumentsOfScenario.Add("job", job);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify user is created successfully using POST request API", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.Given(string.Format("the user sends a POST request with URI as \"{0}\" with body as \"{1}\" and \"{2}\"", uRI, name, job), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.Then("the user verifies the POST request is successful with 201 response code", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 7
 testRunner.And("the user verifies id attribute is displayed in the response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Verify user sends a invalid type for name attribute in the POST request API")]
        [Xunit.TraitAttribute("FeatureTitle", "Test POST Rest API\'s")]
        [Xunit.TraitAttribute("Description", "Verify user sends a invalid type for name attribute in the POST request API")]
        [Xunit.TraitAttribute("Category", "API")]
        [Xunit.TraitAttribute("Category", "NegativeTest")]
        [Xunit.InlineDataAttribute("https://reqres.in/api/users", "20", "leader", new string[0])]
        public virtual void VerifyUserSendsAInvalidTypeForNameAttributeInThePOSTRequestAPI(string uRI, string name, string job, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "API",
                    "NegativeTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("URI", uRI);
            argumentsOfScenario.Add("name", name);
            argumentsOfScenario.Add("job", job);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify user sends a invalid type for name attribute in the POST request API", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 16
 testRunner.Given(string.Format("send POST request with URI as \"{0}\" with invalid type name attribute in the body " +
                            "\"<InvalidTypename>\" and \"{1}\"", uRI, job), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 17
 testRunner.Then("the user verifies invalid type \"name\" is received in response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Verify user sends a invalid type for job attribute in the POST request API")]
        [Xunit.TraitAttribute("FeatureTitle", "Test POST Rest API\'s")]
        [Xunit.TraitAttribute("Description", "Verify user sends a invalid type for job attribute in the POST request API")]
        [Xunit.TraitAttribute("Category", "API")]
        [Xunit.TraitAttribute("Category", "NegativeTest")]
        [Xunit.InlineDataAttribute("https://reqres.in/api/users", "morpheus", "20", new string[0])]
        public virtual void VerifyUserSendsAInvalidTypeForJobAttributeInThePOSTRequestAPI(string uRI, string name, string invalidJobType, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "API",
                    "NegativeTest"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("URI", uRI);
            argumentsOfScenario.Add("name", name);
            argumentsOfScenario.Add("InvalidJobType", invalidJobType);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify user sends a invalid type for job attribute in the POST request API", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
 testRunner.Given(string.Format("send POST request with URI as \"{0}\" with invalid type name attribute in the body " +
                            "\"<InvalidTypename>\" and \"<job>\"", uRI), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
 testRunner.Then("the user verifies invalid type \"job\" is received in response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                TestPOSTRestAPIsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                TestPOSTRestAPIsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion