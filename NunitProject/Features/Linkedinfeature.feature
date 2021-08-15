Feature: Linkedinfeature
	Simple calculator for adding two numbers

@mytag
Scenario: Login linkedIn page
	Given Launch Firefox browser 
	And Navigate to LinkedIn page
	And Enter username and password
	When I click to login
	Then User is logged in and quite browser

@smoketest
Scenario: Create new user
  Given Launch Firefox browser 
  And Navigate to LinkedIn page
  When I click Bli med på link