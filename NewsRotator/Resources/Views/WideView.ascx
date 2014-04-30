<%@ Control Language="C#" %>



<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="sf" %>
<%@ Register Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI.PublicControls" TagPrefix="telerik" %>
<%@ Register Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI" TagPrefix="sitefinity" %>
<sitefinity:ResourceLinks ID="resourcesLinks" runat="server" UseEmbeddedThemes="True">
    <sitefinity:ResourceFile AssemblyInfo="NewsRotator.Rotator, NewsRotator" Name="NewsRotator.Resources.Stylesheets.default.css"
        Static="true" />
    <sitefinity:ResourceFile AssemblyInfo="NewsRotator.Rotator, NewsRotator" Name="NewsRotator.Resources.Stylesheets.WideView.css"
        Static="true" />
    <sitefinity:ResourceFile AssemblyInfo="NewsRotator.Rotator, NewsRotator" Name="NewsRotator.Resources.ScrollScript.js" />
</sitefinity:ResourceLinks>
<sf:RadRotator id="RadRotator1" runat="server" RotatorType="FromCode">
     <ItemTemplate>
        <asp:Panel runat="server" ID="wrapperDiv" class="Box Black">
            <asp:Panel runat="server" ID="ImageBackgroundPanel" CssClass="Image ImageWideView">
                <div class="ArticleBackground ArticleBackgroundWideView"></div>
                <div class="Article ArticleWideView">
                    <sitefinity:SitefinityLabel runat="server" ID="newsTitle" CssClass="Title" WrapperTagName="h2" />
                    <sitefinity:SitefinityLabel runat="server" ID="newsText" CssClass="Summary" WrapperTagName="div" />
                    <asp:HyperLink runat="server" ID="newsLink" CssClass="btnStretch Link"><span>Read more...</span></asp:HyperLink>
                </div>
            </asp:Panel>
            <div style="clear:both;"></div>
        </asp:Panel>
     </ItemTemplate> 
</sf:RadRotator>
<asp:Panel runat="server" ID="navigationDiv" class="Navigation">
    <div class="NavigationItems">
        <a href="#" onclick="showNextItem(this, $find('<%= RadRotator1.ClientID %>'), Telerik.Web.UI.RotatorScrollDirection.Right); return false;"
            class="rotatorButton rotatorButtonPrev" title="Previous"></a><a href="#" onclick="switchMode(this, $find('<%= RadRotator1.ClientID %>'), Telerik.Web.UI.RotatorScrollDirection.Left); return false;"
                class="rotatorButton rotatorButtonPlay" title="Play" runat="server" id="rotatorPlayButton">
            </a><a href="#" onclick="showNextItem(this, $find('<%= RadRotator1.ClientID %>'), Telerik.Web.UI.RotatorScrollDirection.Left); return false;"
                class="rotatorButton rotatorButtonNext" title="Next"></a>
    </div>
</asp:Panel>
<div style="clear: both;">
</div>
