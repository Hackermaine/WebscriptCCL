Use Case:
NewUser Autoscript built to open and Autopopulate multiple HelpDesk ticket web tabs with Username, ManagerName, Location, Department, and Needed Applications

Needs:
 - Needs Selenium import to modify webforms and input keystrokes
 - Needs to parse data from application checkboxes to open a certain amount of tabs (recursion likely needed)
 - Needs to verify no null entries (no empty boxes)
 - Currently null entries are only performed when an application is selected/unselected (chk_apps has changed)
      - Button is always selectable regardless of status or validities of entries
 - Weird Checkbox bug when clicking on application names vs the checkboxes themselves
 
 
 Notes
 - The User needs to already have been authenticated and have an authenticated tab open for the Login Cookies to properly transfer
