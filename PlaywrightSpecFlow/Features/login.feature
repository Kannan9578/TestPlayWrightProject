Feature: Login Page Test

@smoke
Scenario: Verify User is able to login with valid creditial 
	Given I navigate to Login Page
	When I enter username and password
		| UserName | Password |
		| admin    | admin123 |

	And I click on login button
	Then I see the Dashboard page with Text 'Dashboard'