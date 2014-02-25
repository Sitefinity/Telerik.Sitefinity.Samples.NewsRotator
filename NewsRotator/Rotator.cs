using System.ComponentModel;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Sitefinity;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Modules.News.Web.UI;
using Telerik.Sitefinity.Modules.Pages.Web.UI;
using Telerik.Sitefinity.News.Model;
using Telerik.Sitefinity.Pages.Model;
using Telerik.Sitefinity.Web.DataResolving;
using Telerik.Sitefinity.Web.UI;
using Telerik.Sitefinity.Web.UI.ControlDesign;
using Telerik.Web.UI;

namespace NewsRotator
{
    /// <summary>
    /// A control which displays recent news articles in a rotating manner.
    /// </summary>
    [RequireScriptManager]
    [ControlDesigner(typeof(RotatorDesigner)), PropertyEditorTitle(typeof(Labels), "Change")]
    public class Rotator : SimpleView
    {
        /// <summary>
        /// Default provider name.
        /// </summary>
        private string providerName = "OpenAccessDataProvider";

        /// <summary>
        /// Default control height.
        /// </summary>
        private Unit height = new Unit("330px");

        /// <summary>
        /// Default control width.
        /// </summary>
        private Unit width = new Unit("900px");

        /// <summary>
        /// Default news item height.
        /// </summary>
        private Unit itemHeight = new Unit("330px");

        /// <summary>
        /// Default news item width.
        /// </summary>
        private Unit itemWidth = new Unit("900px");

        /// <summary>
        /// Default timespan for each news item slide.
        /// </summary>
        private int frameDuration = 4000;

        /// <summary>
        /// Default amount of displayed news articles.
        /// </summary>
        private int newsLimit = 8;

        /// <summary>
        /// Default timespan of the transition between each news item.
        /// </summary>
        private int scrollDuration = 200;

        /// <summary>
        /// Default template name.
        /// </summary>
        private string layoutTemplateName = "NewsRotator.Resources.Viewtemplate.ascx";

        /// <summary>
        /// Default design setting.
        /// </summary>
        private NewsRotator.RotatorDesign rotatorDesign = RotatorDesign.WideView;

        /// <summary>
        /// Private field for holding the target page with the NewsView. 
        /// </summary>
        private PageNode targetNewsPage;

        /// <summary>
        /// Gets or sets the rotator design.
        /// </summary>
        /// <value>The rotator design.</value>
        public RotatorDesign RotatorDesign
        {
            get
            {
                return this.rotatorDesign;
            }
            
            set
            {
                this.rotatorDesign = value;
            }   
        }

        /// <summary>
        /// Gets or sets the type of the animation.
        /// </summary>
        /// <value>The type of the animation.</value>
        public Telerik.Web.UI.Rotator.AnimationType AnimationType
        {
            get
            {
                this.EnsureChildControls();
                return this.RadRotator1.SlideShowAnimation.Type;
            }
            
            set
            {
                /* possibly evaluate the type
                 * RadRotator1.SlideShowAnimation.Type = (Telerik.Web.UI.Rotator.AnimationType)Enum.Parse(typeof(Telerik.Web.UI.Rotator.AnimationType), RadRotatorAnimationType.Text);
                * */
                this.EnsureChildControls();
                this.RadRotator1.SlideShowAnimation.Type = value;
            }                      
        }

        /// <summary>
        /// Gets or sets the name of the provider.
        /// </summary>
        /// <value>The name of the provider.</value>
        public virtual string ProviderName
        {
            get
            {
                return this.providerName;
            }

            set
            {
                this.providerName = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the Web server control.
        /// </summary>
        /// <value></value>
        /// <returns>A <see cref="T:System.Web.UI.WebControls.Unit"/> that represents the height of the control. The default is <see cref="F:System.Web.UI.WebControls.Unit.Empty"/>.</returns>
        /// <exception cref="T:System.ArgumentException">The height was set to a negative value.</exception>
        public override Unit Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the Web server control.
        /// </summary>
        /// <value></value>
        /// <returns>A <see cref="T:System.Web.UI.WebControls.Unit"/> that represents the width of the control. The default is <see cref="F:System.Web.UI.WebControls.Unit.Empty"/>.</returns>
        /// <exception cref="T:System.ArgumentException">The width of the Web server control was set to a negative value. </exception>
        public override Unit Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the news item slide.
        /// </summary>
        /// <value>The height of the item.</value>
        public Unit ItemHeight
        {
            get
            {
                return this.itemHeight;
            }

            set
            {
                this.itemHeight = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the news item slide.
        /// </summary>
        /// <value>The width of the item.</value>
        public Unit ItemWidth
        {
            get
            {
                return this.itemWidth;
            }

            set
            {
                this.itemWidth = value;
            }
        }

        /// <summary>
        /// Gets or sets the amount of time each slide is shown.
        /// </summary>
        /// <value>The duration of the frame.</value>
        public virtual int FrameDuration
        {
            get
            {
                return this.frameDuration;
            }

            set
            {
                this.frameDuration = value;
            }
        }

        /// <summary>
        /// Gets or sets the speed of the transition between news article slides.
        /// </summary>
        /// <value>The timespan in ms.</value>
        public virtual int ScrollDuration
        {
            get
            {
                return this.scrollDuration;
            }

            set
            {
                this.scrollDuration = value;
            }
        }

        /// <summary>
        /// Gets or sets the limit of news articles to be displayed.
        /// </summary>
        /// <value>Amount of news articles.</value>
        public virtual int NewsLimit
        {
            get
            {
                return this.newsLimit;
            }

            set
            {
                this.newsLimit = value;
            }
        }

        /// <summary>
        /// Gets the name of the embedded layout template.
        /// </summary>
        /// <value></value>
        /// <remarks>
        /// Override this property to change the embedded template to be used with the dialog
        /// </remarks>
        protected override string LayoutTemplateName
        {
            get
            {
                if (this.RotatorDesign != RotatorDesign.Custom)
                {
                    return "NewsRotator.Resources.Views." + this.RotatorDesign.ToString() + ".ascx";
                }

                return this.layoutTemplateName;
            }
        }

        /// <summary>
        /// Gets the <see cref="T:System.Web.UI.HtmlTextWriterTag"/> value that corresponds to this Web server control. This property is used primarily by control developers.
        /// </summary>
        /// <value></value>
        /// <returns>One of the <see cref="T:System.Web.UI.HtmlTextWriterTag"/> enumeration values.</returns>
        protected override HtmlTextWriterTag TagKey
        {
            get
            {
                ////Use div wrapper tag to make easier common styling. This will surround the layout template with a div tag.
                return HtmlTextWriterTag.Div;
            }
        }

        /// <summary>
        /// Gets the target news page.
        /// </summary>
        /// <value>The target news page.</value>
        protected PageNode TargetNewsPage
        {
            get
            {
                if (this.targetNewsPage == null)
                {
                    var settings = App.Prepare();
                    settings.TransactionName = "myTransaction";
                    App.Prepare(settings).WorkWith().Page().PageManager.Provider.SuppressSecurityChecks = true;

                    this.targetNewsPage = App.Prepare(settings).WorkWith().Pages()
                                .Where(p => p.Page != null &&
                                            p.Page.Controls.Where(c => c.ObjectType.StartsWith(typeof(NewsView).FullName)).Count() > 0)
                                .Get().FirstOrDefault();
                } 

                // it can still be null in case there is no page with a NewsView on it
                return this.targetNewsPage;
            }
        }

        /// <summary>
        /// Gets the RadRotator control from the template which is responsible for displaying the news.
        /// </summary>
        /// <value>Instance of a Telerik RadRotator control.</value>
        protected virtual RadRotator RadRotator1
        {
            get
            {
                return this.Container.GetControl<RadRotator>("RadRotator1", true);
            }
        }

        /// <summary>
        /// Gets the div displaying the navigation
        /// </summary>
        protected Panel NavigationDiv
        {
            get
            {
                return this.Container.GetControl<Panel>("navigationDiv", true);
            }
        }

        /// <summary>
        /// Initializes the controls.
        /// </summary>
        /// <param name="controlContainer">The control container.</param>
        protected override void InitializeControls(GenericContainer controlContainer)
        {
            var dataSource = App.WorkWith().NewsItems().Publihed()
                                                 .Get().Take(this.NewsLimit)
                                                 .ToList()
                                                 .Join(
                                                     App.WorkWith().Images().Publihed()
                                                     .Get()
                                                     .Where(i => i.Parent.Title == "Thumbnails"),
                                                         item => item.Title.Value,
                                                         image => image.Title.Value,
                                                         (item, image) => new { NewsItem = item, NewsImage = image }
                                                 );

            //var news = App.WorkWith().NewsItems().Where(n => n.Status == ContentLifecycleStatus.Live).Get().Take(this.NewsLimit).ToList();
            //var images = App.WorkWith().Images().Get().Where(i => i.Parent.Title == "Thumbnails" && i.Status == ContentLifecycleStatus.Live);
            
            this.RadRotator1.DataSource = dataSource;
            

            this.RadRotator1.ItemDataBound += new RadRotatorEventHandler(this.RadRotator1_ItemDataBound);
            this.RadRotator1.DataBind();

            this.RadRotator1.Height = this.Height;
            this.RadRotator1.Width = this.Width;
            this.RadRotator1.ItemHeight = this.ItemHeight;
            this.RadRotator1.ItemWidth = this.ItemWidth;
            this.RadRotator1.FrameDuration = this.FrameDuration;
            this.RadRotator1.ScrollDuration = this.ScrollDuration;
            this.NavigationDiv.Width = this.Width;
        }

        /// <summary>
        /// Handles the ItemDataBound event of the RadRotator1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Telerik.Web.UI.RadRotatorEventArgs"/> instance containing the event data.</param>
        protected void RadRotator1_ItemDataBound(object sender, RadRotatorEventArgs e)
        {
            var link = e.Item.FindControl("newsLink") as HyperLink;
            var image = e.Item.FindControl("newsImage") as Image;
            var imageBackgroundPanel = e.Item.FindControl("ImageBackgroundPanel") as Panel;
            var title = e.Item.FindControl("newsTitle") as Label;
            var text = e.Item.FindControl("newsText") as Label;

            NewsItem newsItem = (NewsItem)TypeDescriptor.GetProperties(e.Item.DataItem)["NewsItem"].GetValue(e.Item.DataItem);
            Telerik.Sitefinity.Libraries.Model.Image newsImage = (Telerik.Sitefinity.Libraries.Model.Image)TypeDescriptor.GetProperties(e.Item.DataItem)["NewsImage"].GetValue(e.Item.DataItem);

            if (image != null)
            {
                image.ImageUrl = newsImage.MediaUrl;
            }

            if (imageBackgroundPanel != null)
            {
                imageBackgroundPanel.BackImageUrl = newsImage.MediaUrl;
            }

            if (title != null)
            {
                title.Text = newsItem.Title;
            }

            if (text != null)
            {
                text.Text = newsItem.Summary;
            }

            if (link != null && this.TargetNewsPage != null)
            {
                link.NavigateUrl = DataResolver.Resolve(newsItem, "URL", null, this.TargetNewsPage.Id.ToString());
            }

            var wrapperDiv = e.Item.FindControl("wrapperDiv") as Panel;
            if (wrapperDiv != null)
            {
                wrapperDiv.Width = this.Width;
                wrapperDiv.Height = this.Height;
            }
        }
    }
}
