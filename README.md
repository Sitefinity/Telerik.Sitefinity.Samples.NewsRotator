Telerik.Sitefinity.Samples.NewsRotator
======================================

The NewsRotator sample project contains a simple Sitefinity widget that rotates news and images present in the Sitefinity backend. The sample features a custom designer that allows you to change the front-end rendering of the widget by switching its template. The NewsRotator widget is built on top of RadRotator widget, part of RadControls for ASP.NET Ajax delivered with this toolkit.

You can run the sample with any type of license. 

Using the NewsRotator sample, you can:

* Create a NewRotator widget
* Register the widget in Sitefinity toolbox
* Create a custom designer to change the widget's template at runtime


### Requirements

* Sitefinity 6.3 license

* .NET Framework 4

* Visual Studio 2012

* Microsoft SQL Server 2008R2 or later versions


### Installation instructions: SDK Samples from GitHub

1. Clone the [Telerik.Sitefinity.Samples.Dependencies](https://github.com/Sitefinty-SDK/Telerik.Sitefinity.Samples.Dependencies) repo to get all assemblies necessary to run for the samples.
2. Fix broken references in the class libraries, for example in **SitefinityWebApp** and **Telerik.Sitefinity.Samples.Common**:

  1. In Solution Explorer, open the context menu of your project node and click _Properties_.  
  
    The Project designer is displayed.
  2. Select the _Reference Paths_ tab page.
  3. Browse and select the folder where **Telerik.Sitefinity.Samples.Dependencies** folder is located.
  4. Click the _Add Folder_ button.


3. In Solution Explorer, navigate to _SitefinityWebApp_ -> *App_Data* -> _Sitefinity_ -> _Configuration_ and select the **DataConfig.config** file. 
4. Modify the **connectionString** value to match your server address.
5. Build the solution.

### Login

To login to Sitefinity backend, use the following credentials: 

**Username:** admin

**Password:** password

### Additional resources

[Developers Guide](http://www.sitefinity.com/documentation/documentationarticles/developers-guide)

[Create a NewsRotaor widget as a custom widget](http://www.sitefinity.com/documentation/documentationarticles/developers-guide/how-to/how-to-create-a-newsrotator-control/creating-the-newsrotator-as-a-custom-control)

[Create a NewsRotaor widget as a user widget](http://www.sitefinity.com/documentation/documentationarticles/developers-guide/how-to/how-to-create-a-newsrotator-control/creating-the-newsrotator-as-a-user-control)

