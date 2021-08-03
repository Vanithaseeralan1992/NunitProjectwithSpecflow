Feature: SpecFlowFeature1
	Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@smoketest
Scenario: Subtract two numbers
	Given the first number is 120
	And the second number is 70
	When the two numbers are subtracted
	Then the result should be 50


@sanitytest
Scenario: Create a new employee with mandatory details
#Given I have opened my application
#Then I should see employee details page
When I fill all the mandatory datails in form
| Name     | Age | Phone    | Email              |
| Vanitha  | 28  | 97380179 | vanitha@gmail.com  |
| Seeralan | 38  | 40486174 | seeralan@gmail.com |
| Pavin    | 05  | 12345678 | pavin@gmail.com    |
| Thejasri | 03  | 98765432 | thejasri@gmail.com |
#And I click the save button
#Then I should see all the details saved in my application and DB