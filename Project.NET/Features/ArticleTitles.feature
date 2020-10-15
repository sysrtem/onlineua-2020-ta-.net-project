Feature: ArcitleTitlesCheck

Background: 
Given user navigate to the NewsPage

@mytag
Scenario: Check that the headline article's title in the NewsPage is correct		
	When user get the headline article's title
	Then the headline article's title is "Europe's Covid restrictions 'absolutely necessary'"

Scenario: Check that secondary articles titles in the NewsPage are correct
	When user get a list of secondary articles titles
	Then secondary articles titles correspond
	| articles                                           |
	| French police raid officials' homes in virus probe |
	| Johnson details three-tier Covid rules for England |
	| US auction theorists win Nobel Economics Prize     |
	| Italian teenager could be first millennial saint   |
	| Top US scientist says Trump ad quote misleading    |
	| China to test whole city for Covid-19 in five days |
	| A brand new hand, from my brother                  |
	| Lakers pay tribute to Bryant after NBA title win   |
	| Pope Francis meets acquitted Cardinal Pell         |
	| Nigeria leader pledges 'extensive' police reforms  |
	| Pope Francis meets acquitted Cardinal Pell         |
	| Nigeria leader pledges 'extensive' police reforms  |
	| Israel unblocks big immigration of Ethiopian Jews  |
	| Bangladesh to introduce death penalty for rape     |
	| Six people shot dead in El Salvador bar attack     |

Scenario: Check that search by category link shows correct article	
	When user search by category link
	Then the first article's title is "Woman arrested at US-Canada border for poison mailed to White House"