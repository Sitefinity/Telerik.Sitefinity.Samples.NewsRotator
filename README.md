Telerik.Sitefinity.Samples.NewsRotator
======================================

[![Build Status](http://sdk-jenkins-ci.cloudapp.net/buildStatus/icon?job=Telerik.Sitefinity.Samples.NewsRotator.CI)](http://sdk-jenkins-ci.cloudapp.net/job/Telerik.Sitefinity.Samples.NewsRotator.CI/)

The NewsRotator sample project contains a simple Sitefinity widget that rotates news and images present in the Sitefinity backend. The sample features a custom designer that allows you to change the front-end rendering of the widget by switching its template. The NewsRotator widget is built on top of RadRotator widget, part of RadControls for ASP.NET Ajax delivered with this toolkit.

You can run the sample with any type of license. 

Using the NewsRotator sample, you can:

* Create a NewRotator widget
* Register the widget in Sitefinity toolbox
* Create a custom designer to change the widget's template at runtime


### Requirements

* Sitefinity license
* .NET Framework 4
* Visual Studio 2012
* Microsoft SQL Server 2008R2 or later versions

### Prerequisites

Clear the NuGet cache files. To do this:

1. In Windows Explorer, open the **%localappdata%\NuGet\Cache** folder.
2. Select all files and delete them.

### Nuget package restoration
The solution in this repository relies on NuGet packages with automatic package restore while the build procedure takes place.   
For a full list of the referenced packages and their versions see the [packages.config](https://github.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.NewsRotator/blob/master/SitefinityWebApp/packages.config) file.    
For a history and additional information related to package versions on different releases of this repository, see the [Releases page](https://github.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.NewsRotator/releases).    


### Installation instructions: SDK Samples from GitHub


1. In Solution Explorer, navigate to _SitefinityWebApp_ -> *App_Data* -> _Sitefinity_ -> _Configuration_ and select the **DataConfig.config** file. 
2. Modify the **connectionString** value to match your server address.

For version-specific details about the required Sitefinity NuGet packages for this sample application, click on [Releases]
 (https://github.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.NewsRotator/releases).


### Login

To login to Sitefinity backend, use the following credentials: 

**Username:** admin
**Password:** password

### Additional resources

[Developers Guide](http://www.sitefinity.com/documentation/documentationarticles/developers-guide)
[Create a NewsRotaor widget as a custom widget](http://www.sitefinity.com/documentation/documentationarticles/developers-guide/how-to/how-to-create-a-newsrotator-control/creating-the-newsrotator-as-a-custom-control)
[Create a NewsRotaor widget as a user widget](http://www.sitefinity.com/documentation/documentationarticles/developers-guide/how-to/how-to-create-a-newsrotator-control/creating-the-newsrotator-as-a-user-control)

