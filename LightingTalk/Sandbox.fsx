//Highlight each line one at a time and press Alt+Enter
#I @"..\packages\Selenium.WebDriver.2.45.0\lib\net40\"
#I @"..\packages\Selenium.Support.2.45.0\lib\net40\"
#I @"..\packages\SizSelCsZzz.0.3.36.0\lib\"
#I @"..\packages\Newtonsoft.Json.6.0.8\lib\net40\"
#I @"..\packages\canopy.0.9.22\lib\"
#r "WebDriver.Support.dll"
#r "WebDriver.dll"
#r "canopy.dll"

open canopy
open runner

start chrome

url "http://github.com"
click "a[href='/login']"
"#login_field" << "YOUR USERNAME"
"#password" << "YOUR PASSWORD"
click "input[value='Sign in']"
"input[placeholder='Search GitHub']" << "canopy"
press enter
click (first ".repo-list-item h3 a")
click "button[aria-label='Fork your own copy of lefthandedgoat/canopy to your account']"
