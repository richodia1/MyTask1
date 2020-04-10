Feature: RegistrationFeature
	In order to Register User Successfully
	As an API Consumer
	I want to be able to register a new user with an error or successful response.

Scenario: To Register User Successfully without error response
	Given that a user want to register successfully with valid 'email':email and 'password':password
	When I trigger Post request registration
	Then I should get a successful registration response with token using 'email':email and 'password':password

Scenario: To register UnSuccessfully with error response
	Given that a user Register with an incomplete input parameter with email: 'email' and invalid password: 'password':
	When I trigger Post request registration
	Then my response code for incomplete input registration should be 400 badrequest and error response