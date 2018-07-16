NewsRotator sample project
======================================

>**Latest supported version**: Sitefinity CMS 11.0.6700.0

>**Documentation articles**: [Tutorial: Create a NewsRotator widget](http://docs.sitefinity.com/tutorial-create-a-newsrotator-widget-webforms)

### Overview

The NewsRotator sample project contains a simple Sitefinity CMS widget that rotates news and images present in the Sitefinity CMS backend. The sample features a custom designer that allows you to change the front-end rendering of the widget by switching its template. The NewsRotator widget is built on top of RadRotator widget, part of RadControls for ASP.NET Ajax delivered with this toolkit.

Using the NewsRotator sample, you can:   
 - Create a NewRotator widget
 - Register the widget in Sitefinity CMS toolbox
 - Create a custom designer to change the widget's template at runtime

### Prerequisites

- You must have a Sitefinity CMS license.
- Your setup must comply with the system requirements.  
 For more information, see the [System requirements](https://docs.sitefinity.com/system-requirements) for the  respective Sitefinity CMS version.
 
### Installation

1. Clear the NuGet cache files.  
 a. Open the `NewsRotatorWidget` solution file in Visual Studio.  
 b. In the toolbar, navigate to _Tools >> NuGet Package Manager >> Package Manager Settings_.  
 c. In the left pane, navigate to _NuGet Package Manager >> General_.  
 d. Click _Clear All NuGet Cache(s)_.
2. Restore the NuGet packages in the solution.  
   
   >**NOTE**: The solution in this repository relies on NuGet packages with automatic package restore while the build procedure takes place.   
   >For a full list of the referenced packages and their versions see the [packages.config](https://github.com/Sitefinity/Telerik.Sitefinity.Samples.NewsRotator/blob/master/SitefinityWebApp/packages.config) file of the `SitefinityWebApp` and the the [packages.config](https://github.com/Sitefinity/Telerik.Sitefinity.Samples.NewsRotator/blob/master/NewsRotator/packages.config) file of the `NewsRotator` library.    
   >For a history and additional information related to package versions on different releases of this repository, see the [Releases page](https://github.com/Sitefinity/Telerik.Sitefinity.Samples.NewsRotator/releases).
   >  
   a. Navigate to _Tools >> NuGet Package Manager >> Package Manager Console_.  
   b. In _Source_, select Sitefinity CMS NuGet Repository.  
   c. Click _Restore_ button.
3. In Visual Studio's _Solution Explorer_, navigate to _SitefinityWebApp_ >> _App_Data_ >> _Sitefinity_ >> _Configuration_ and select the `StartupConfig.config` file. 
4. Modify the `dbType`, `sqlInstance`, and `dbName` values to match your server settings.
5. Build the solution.

### Login

1. In the context menu of SitefinityWebApp, click _View >> View in Browser_.  
 After the project initializes, the _License activation_ page appears.
2. Activate your license.  
 For more information, see [Activate a license](http://docs.sitefinity.com/activate-a-license).
3. Setup the project using procedure using procedure [Setup the project](https://docs.sitefinity.com/configure-and-start-a-project).
4. To login into the Sitefinity CMS backend, use the following credentials:  
 **Username:** admin  
 **Password:** password

### Additional resources
Progress Sitefinity CMS Documentation: [Development: Use and extend Sitefinity CMS functionality](http://docs.sitefinity.com/develop-create-and-manage-website-content)
