<h1>dotNet-Playwright example for AART Interview (Mac Only)</h1>

* Install .NET SDK for Mac

* Open Terminal and CD to Project's Root directory  
  
* Install Playwright  
  dotnet add package Microsoft.Playwright  

* Build Test
  dotnet build  
  
* Execute test:
  dotnet test -- Playwright.BrowserName=chromium Playwright.LaunchOptions.Headless=false   
  
