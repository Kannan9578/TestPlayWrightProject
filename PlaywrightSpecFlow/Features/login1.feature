Feature: Login Page Test1

@smoke
Scenario: Verify User is able to login with valid creditial 1
	Given I navigate to Login Page
	When I enter username and password
		| UserName | Password |
		| admin    | admin123 |

	And I click on login button
	Then I see the Dashboard page with Text 'Dashboard'

	@smoke
Scenario Outline: Verify User is able to login with valid <UserName>
	Given I navigate to Login Page
	When I enter username :<UserName> and password: <Password>
	And I click on login button
	Then I see the Dashboard page with Text 'Dashboard'
	Examples: 
	| UserName | Password |
	| Admin    | admin123 |
	| admin   | admin123 |