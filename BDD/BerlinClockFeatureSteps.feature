
Feature: The Berlin Clock
	As a clock enthusiast
    I want to tell the time using the Berlin Clock
    So that I can increase the number of ways that I can read the time


Scenario: Midnight 00:00
When the time is "00:00:00"
Then the clock should look like
"""
Y
OOOO
OOOO
OOOOOOOOOOO
OOOO
"""

Scenario: Noon
When the time is "12:00:00"
Then the clock should look like
"""
Y
RROO
RROO
OOOOOOOOOOO
OOOO
"""


Scenario: Middle of the afternoon
When the time is "13:17:01"
Then the clock should look like
"""
O
RROO
RRRO
YYROOOOOOOO
YYOO
"""

Scenario: Late afternoon
When the time is "18:52:00"
Then the clock should look like
"""
Y
RRRO
RRRO
YYRYYRYYRYO
YYOO
"""

#Scenario: Out of bound exception
#When the time is "24:17:01"
#Then the should thow exception

Scenario: Just before midnight
When the time is "23:59:59"
Then the clock should look like
"""
O
RRRR
RRRO
YYRYYRYYRYY
YYYY
"""

Scenario: Midnight 24:00
When the time is "24:00:00"
Then the clock should look like
"""
Y
RRRR
RRRR
OOOOOOOOOOO
OOOO
"""
