Feature: Test POST Rest API's 

@API @PositiveTest
Scenario: Verify user is created successfully using POST request API
	Given the user sends a POST request with URI as "<URI>" with body as "<name>" and "<job>"
	Then the user verifies the POST request is successful with 201 response code
	And the user verifies id attribute is displayed in the response 

	Examples:
	| URI                         | name         | job    |
	| https://reqres.in/api/users | morpheus     | leader |


@API @NegativeTest
Scenario: Verify user sends a invalid type for name attribute in the POST request API
	Given send POST request with URI as "<URI>" with invalid type name attribute in the body "<InvalidTypename>" and "<job>"
	Then the user verifies invalid type "name" is received in response

	Examples:
	| URI                         | name        | job    |
	| https://reqres.in/api/users | 20			| leader |

@API @NegativeTest
Scenario: Verify user sends a invalid type for job attribute in the POST request API
	Given send POST request with URI as "<URI>" with invalid type name attribute in the body "<InvalidTypename>" and "<job>"
	Then the user verifies invalid type "job" is received in response

	Examples:
	| URI                         | name        | InvalidJobType    |
	| https://reqres.in/api/users | morpheus	| 20				|