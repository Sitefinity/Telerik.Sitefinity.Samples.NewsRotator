Progress.Sitefinity.Samples.NewsRotator
======================================

### Latest supported version: Sitefinity CMS 11.0.6700.0

The NewsRotator sample project contains a simple Sitefinity CMS widget that rotates news and images present in the Sitefinity CMS backend. The sample features a custom designer that allows you to change the front-end rendering of the widget by switching its template. The NewsRotator widget is built on top of RadRotator widget, part of RadControls for ASP.NET Ajax delivered with this toolkit.

You can run the sample with any type of license. 

Using the NewsRotator sample, you can:

* Create a NewRotator widget
* Register the widget in Sitefinity CMS toolbox
* Create a custom designer to change the widget's template at runtime


### Requirements

You must have a Sitefinity CMS license

For more information, see the [System requirements](https://docs.sitefinity.com/system-requirements) for the  respective Sitefinity CMS version.

### Prerequisites

Clear the NuGet cache files. To do this:

1. In Windows Explorer, open the **%localappdata%\NuGet\Cache** folder.
2. Select all files and delete them.

### Nuget package restoration
The solution in this repository relies on NuGet packages with automatic package restore while the build procedure takes place.   
For a full list of the referenced packages and their versions see the [packages.config](https://github.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.NewsRotator/blob/master/SitefinityWebApp/packages.config) file.    
For a history and additional information related to package versions on different releases of this repository, see the [Releases page](https://github.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.NewsRotator/releases).    


### Installation instructions: SDK Samples from GitHub


1. In Solution Explorer, navigate to _SitefinityWebApp_ » *App_Data* » _Sitefinity_ » _Configuration_ and select the **StartupConfig.config** file. 
2. Modify the **dbType**, **sqlInstance** and **dbName** values to match your server settings.
3. Build the solution.

For version-specific details about the required Sitefinity CMS NuGet packages for this sample application, see [Releases](https://github.com/Sitefinity-SDK/Telerik.Sitefinity.Samples.NewsRotator/releases).


### Login

To login into the Sitefinity CMS backend, use the following credentials: 

**Username:** admin  
**Password:** password

### Additional resources
Progress Sitefinity CMS Documentation
* [Development: Use and extend Sitefinity CMS functionality](http://docs.sitefinity.com/develop-create-and-manage-website-content)
* [NewsRotator widget: Create the NewsRotator as a custom widget](http://docs.sitefinity.com/newsrotator-widget-create-the-newsrotator-as-a-custom-widget)
* [NewsRotator widget: Create the NewsRotator as a user widget](http://docs.sitefinity.com/newsrotator-widget-create-the-newsrotator-as-a-user-widget)

