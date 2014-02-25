using NewsRotator;
using System;
using Telerik.Sitefinity;
using System.Linq;
using System.Resources;
using System.Web;
using Telerik.Sitefinity.Workflow;
using Telerik.Sitefinity.News.Model;
using System.Collections.Generic;
using Telerik.Sitefinity.Modules.News;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Modules.News.Web.UI;
using Telerik.Sitefinity.Modules.Libraries;
using System.Web.UI;
using Telerik.Sitefinity.Samples.Common;
using Telerik.Sitefinity.Services;
using Telerik.Sitefinity.Data.OA;

namespace SitefinityWebApp
{
    public class Global : System.Web.HttpApplication
    {
        private const string SamplesThemeName = "SamplesTheme";
        private const string SamplesThemePath = "~/App_Data/Sitefinity/WebsiteTemplates/Samples/App_Themes/Samples";

        private const string SamplesTemplateId = "015b4db0-1d4f-4938-afec-5da59749e0e8";
        private const string SamplesTemplateName = "SamplesMasterPage";
        private const string SamplesTemplatePath = "~/App_Data/Sitefinity/WebsiteTemplates/Samples/App_Master/Samples.master";

        private const string NewsRotatorWidgetPageId = "b210e2f7-3a43-4621-a729-9c13b463a6c4";
        private const string NewsRotatorWidgetPageName = "NewsRotator Sample";
        private const string NewsPageId = "C9C544BF-1152-4223-94DB-6119CD5E973A";

        protected void Application_Start(object sender, EventArgs e)
        {
            Telerik.Sitefinity.Abstractions.Bootstrapper.Initialized += new EventHandler<Telerik.Sitefinity.Data.ExecutedEventArgs>(Bootstrapper_Initialized);
        }        

        protected void Bootstrapper_Initialized(object sender, Telerik.Sitefinity.Data.ExecutedEventArgs args)
        {
            if (args.CommandName == "Bootstrapped")
            {
                SystemManager.RunWithElevatedPrivilegeDelegate worker = new SystemManager.RunWithElevatedPrivilegeDelegate(CreateSampleWorker);
                SystemManager.RunWithElevatedPrivilege(worker);
            }
        }

        private void CreateSampleWorker(object[] args)
        {            
            SampleUtilities.CreateUsersAndRoles();
            SampleUtilities.RegisterToolboxWidget("NewsRotator Widget", typeof(Rotator), "Samples");
            SampleUtilities.RegisterTheme(SamplesThemeName, SamplesThemePath);
            SampleUtilities.RegisterTemplate(new Guid(SamplesTemplateId), SamplesTemplateName, SamplesTemplateName, SamplesTemplatePath, SamplesThemeName);

            SampleUtilities.UploadImages(HttpRuntime.AppDomainAppPath + "Images", "Thumbnails");
            this.CreateNewsItems();

            var result = SampleUtilities.CreatePage(new Guid(NewsPageId), "News");

            if (result)
            {
                SampleUtilities.SetTemplateToPage(new Guid(NewsPageId), new Guid(SamplesTemplateId));

                NewsView newsView = new NewsView();
                SampleUtilities.AddControlToPage(new Guid(NewsPageId), newsView, "Content", "News");
            }

            result = SampleUtilities.CreatePage(new Guid(NewsRotatorWidgetPageId), NewsRotatorWidgetPageName, true);

            if (result)
            {
                SampleUtilities.SetTemplateToPage(new Guid(NewsRotatorWidgetPageId), new Guid(SamplesTemplateId));

                Rotator newsRotator = new Rotator();
                SampleUtilities.AddControlToPage(new Guid(NewsRotatorWidgetPageId), newsRotator, "Content", "NewsRotator Widget");
            }            

            //create admin
            SampleUtilities.CreateUsersAndRoles();
            //SampleUtilities.FrontEndAuthenticate();
        }

        private void CreateNewsItems()
        {            
            var newsCreated = App.WorkWith().NewsItems().Get().Count() > 0;

            if (!newsCreated)
            {
                var newsTitle = "Lorem Ipsum 1.jpg";
                var newsDescription = "Lorem Ipsum 1.jpg";
                var newsContent = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem. Investigationes demonstraverunt lectores legere me lius quod ii legunt saepius. Claritas est etiam processus dynamicus, qui sequitur mutationem consuetudium lectorum. Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima. Eodem modo typi, qui nunc nobis videntur parum clari, fiant sollemnes in futurum.";

                SampleUtilities.CreateNewsItem(newsTitle, newsDescription, newsContent);

                newsTitle = "Lorem Ipsum 2.jpg";
                newsDescription = "Lorem Ipsum 2.jpg";

                SampleUtilities.CreateNewsItem(newsTitle, newsDescription, newsContent);

                newsTitle = "Lorem Ipsum 3.jpg";
                newsDescription = "Lorem Ipsum 3.jpg";

                SampleUtilities.CreateNewsItem(newsTitle, newsDescription, newsContent);

                newsTitle = "Lorem Ipsum 4.jpg";
                newsDescription = "Lorem Ipsum 4.jpg";

                SampleUtilities.CreateNewsItem(newsTitle, newsDescription, newsContent);

                newsTitle = "Lorem Ipsum 5.jpg";
                newsDescription = "Lorem Ipsum 5.jpg";

                SampleUtilities.CreateNewsItem(newsTitle, newsDescription, newsContent);

                newsTitle = "Lorem Ipsum 6.jpg";
                newsDescription = "Lorem Ipsum 6.jpg";

                SampleUtilities.CreateNewsItem(newsTitle, newsDescription, newsContent);
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}