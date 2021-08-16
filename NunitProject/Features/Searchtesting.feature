Feature: Searchtesting
	

@mytag
Scenario: Simple search with testing key
	Given Launch Chrome browser
	And Navidage to code.com project
	When Click on SEarch our Articles
	When Enter Testing
	And Click on Search Button
	Then Result should be visible and Browser should close