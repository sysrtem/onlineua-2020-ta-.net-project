Feature: ShareForm	

Background: 
Given user navigates to HowToShare page

@mytag
Scenario: Check if user can submit a story wittout terms of service accepted
When user confirm age "true" and terms of cervice "false"
And  submit the story
| Key                 | Vaue              |
| Tell us your story. | story             |
| Name                | name              |
| Email address       | email@email.email |
| Contact number      | +380111111111     |
| Location            | Kyiv              |
Then the error message "must be accepted" should appear

Scenario: Check if user can submit a story with invalid email
When user confirm age "true" and terms of cervice "true"
And submit the story with invalid email 
| Key                 | Vaue            |
| Tell us your story. | story           |
| Name                | name            |
| Email address       | emailemailemail |
| Contact number      | +380111111111   |
| Location            | Kyiv            |
Then the error message "Email address is invalid" should appear

Scenario: Check if user can submit a story with empty story field
When user confirm age "true" and terms of cervice "true"
And submit the story with empty story field
| Key                 | Vaue              |
| Tell us your story. |                   |
| Name                | name              |
| Email address       | email@email.email |
| Contact number      | +380111111111     |
| Location            | Kyiv              |
Then the error message "can't be blank" should appear

	