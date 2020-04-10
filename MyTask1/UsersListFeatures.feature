Feature: UsersListFeatures
	In order to fetch users list from the API
	As an API consumer
	I want to fetch all users list for a single API call


Scenario: Get all Users from the API
	Given that a user exist on the system with a return status code of 200
	When I trigger Http Get request
	Then I should get all the list of users
