Feature: Education
	

@mytag
Scenario: Add Education to Profile
	Given Click On Education
	And Click on Addnew to fill the education details
	And Enter college or university
	And Country of college or university from dropdown
	And Select degree type from the dropdown
	And Enter name of the degree
	And Select year of graduation from dropdown
	Then Click on Add to save the education details

	