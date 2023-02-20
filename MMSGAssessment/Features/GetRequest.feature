Feature: Test GET Rest API's  

@API @PositiveTest
Scenario: Verify single user by GET request API
	Given the user sends a get request with URI as "<URI>"
	Then the user verifies the request is successful with 200 response code

	Examples:
	| URI                           |
	| https://reqres.in/api/users/2 | 

@API @PositiveTest
Scenario: Verify List of users by GET request API
	Given the user sends a get request with URI as "<URI>"
	Then the user verifies the request is successful with 200 response code
	And the user verifies "<FirstName>" and "<LastName>" is displayed in the output response

	Examples:
	| URI                                | FirstName | LastName |
	| https://reqres.in/api/users?page=2 | Lindsay   | Ferguson |


@API @NegativeTest
Scenario: Verify user sends invalid user GET API request
	Given the user sends a get request with URI as "<InvalidUserURI>"
	Then the user verifies the request is not successful

	Examples:
	| InvalidUserURI                  |
	| https://reqres.in/api/users/100 | 