# InPocket
Dot Net Project


Tools -> NuGet Package Manager 

---------   For Migration with one context or multiple context   ---------

Enable-Migrations
Add-Migration MigrationName
Update-Database  

Enable-Migrations -ContextTypeName AssmeblyName.Models.ContextName
Add-Migration -ConfigurationTypeName ConfigurationSeedName
Update-Database -ConfigurationTypeName ConfigurationSeedName

---------   To Install PlugIn   ---------

Install-Package EntityFramework
Install-Package PagedList.Mvc
