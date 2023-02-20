# MMSGAssessment
Mcmillan Shakespeare Code Assessment

# Introduction 

- MMSG Coding API Assessment. API Automation Tests built on C# and Spec flow. 

## Description:
- All tests are fully automated and executed successfully. 
- Execution reports are attached in reports folder.
- Automated using C# programming language, xunit, specflow(BDD) and NewtonSoft.Json libarary.
- IDE : Visual studio 2019
- Design: Page object model design pattern. Feature files, step definitions, separate classes for step definition methods and Hooks.
- Feature files: Indicates user readable scenarios in BDD style.
- Step definitions: Binding files from feature files
- Method Class: Technical implementations and validation of scenarios. 
- Code is quite reusable and easy to maintain. Used Specflow Scenario Context, xUnit Assert functions to validated actual results.
- Hooks: Used sample Before Scenario and After Scenario Hooks.
- Added both positive and negative tests. Used Specflow tags to differentiate positive and negative tests.

## Steps To import project:
-	Clone the project from following url https://github.com/rakeshd2325/MMSGAssessment.git
-	Open “MMSGAssessment.sln” file in visual studio
-	Go to Extensions on visual studio IDE. Install Specflow plugin from Manage Extensions(Need to restart visual studio)
-	Wait until all dependencies are loaded.
-	Open Test ->Test Explorer from  Menu and run the tests.

## Reports
- Reports are generated using Specflow Living doc. Please find reports in reports folder.


## Any Questions?

- Rakesh Singh (rakeshd2323@gmail.com)
