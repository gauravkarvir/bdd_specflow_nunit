# BDD SpecFlow Webdriver Nunit Framework

### Uses:  
+ SpecFlow 2 (Cucumber BDD)
+ Selenium (WebDriver)
+ NUnit 2.x
+ specflow-report-templates 
+ pickles (documentation generator for features and scenarios)
+ utilises Page Object Model pattern
+ can be run using Jenkins
+ runs tests locally or in saucelabs (account required) and reports results back to the Jenkins job
+ takes screenshots on failure of web tests

## Background reading: 
* Getting started with Specflow: http://ralucasuditu-softwaretesting.blogspot.co.uk/2015/06/write-your-first-test-with-specflow-and.html?m=1

##Getting started
1. Install Visual Studio (Enterprise 2015)
2. Install NuGet (package manager). http://docs.nuget.org/consume/package-manager-dialog#managing-packages-for-the-solution
3. Use NuGet (Project > Manage NuGet packages) to install Specflow, Nunit and Selenium:
4. Add Reference (Project > Add Reference) for System.Configuration (enables the use of app.config file items) 
5. Environment variables in Windows (Configure Reports and Runners from command line)
	System Properties>Advanced> Add new vaiable
		Variable name: SPECFLOW
		Variable values: C:\Workspaces\bdd-specflow-automation\packages
		* The value is the location of this project packages directory
	
	Edit Path Variable:  And in the end add the below entries
	%SPECFLOW%\NUnit.Runners.2.6.4\tools;%SPECFLOW%\SpecFlow.2.1.0\tools\;%SPECFLOW%\Pickles.CommandLine.2.0.1\tools;%SPECFLOW%\ReportUnit.1.2.1\tools
  
