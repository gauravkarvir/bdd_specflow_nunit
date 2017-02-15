Feature: Navigate
#This is a sample Feature file with an example of a single scenario.
#Every feature file starts with "Feature:" Keyword which describes what Feature is under test.
#tags are used for running entire Feature, a single Scenario or group of Feature or Scenarios.
#Tags are annotated with "@" symbol

 

@login
Scenario Outline: Navigate and Login to Home Page
	Given I navigate to Login Page
	When I enter login details for <userType>
    Then i can see the validation error message

	Examples:
	| userType     |
	| invalidAdmin |
	| invalidUser             |

	
	


