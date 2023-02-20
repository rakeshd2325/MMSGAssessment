Feature: Test Update PUT Rest API's

@API @PositiveTest
Scenario: Verify record is updated successfully using PUT request API
	Given the user sends a PUT request with URI as "<URI>" with body as "<name>" and new job as "<job>"
	Then the user verifies the PUT request is successful with 200 response code
	And the user verifies updated "<job>" in the PUT response

	Examples:
	| URI                           | name         | job		   |
	| https://reqres.in/api/users/2 | morpheus     | zion resident |

@API @NegativeTest
Scenario: Verify user tries to update invalid job type attribute in the PUT request API
	Given the user sends a PUT request with URI as "<URI>" with body as "<name>" and new job as "<InvalidJobType>"
	Then the user verifies the request is not successful

	Examples:
	| URI                         | name        | InvalidJobType    |
	| https://reqres.in/api/users | morpheus	| 20				|