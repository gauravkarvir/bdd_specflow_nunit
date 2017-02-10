@web
Feature: Navigate and Login to HomePage
 

@login
Scenario Outline: Navigate and Login to Home Page
	Given I navigate to Login Page
	When I enter login details for <userType>
	Then the user is successfully logged on and is on the Home Page
	When the user logs off
	Then the user is successfully logged off
	Examples:
	| userType                                                |
	| admin                                             |
	| user                                             |

	
	