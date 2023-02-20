Feature: Test Update PATCH Rest API's

@API @PositiveTest
Scenario: Verify record is updated successfully using PATCH request API
	Given the user sends a PATCH request with URI as "<URI>" with body as "<name>" and new job as "<job>"
	Then the user verifies the PATCH request is successful with 200 response code
	And the user verifies updated "<job>" in the PATCH response

	Examples:
	| URI                           | name         | job		   |
	| https://reqres.in/api/users/2 | morpheus     | zion resident |

@API @NegativeTest
Scenario: Verify user tries to update invalid job type attribute in the PATCH request API
	Given the user sends a PATCH request with URI as "<URI>" with body as "<name>" and new job as "<InvalidJobType>"
	Then the user verifies the request is not successful

	Examples:
	| URI                         | name        | InvalidJobType    |
	| https://reqres.in/api/users | morpheus	| 20				|