<%@ Control Language="C#" %>



<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="sf" %>
<%@ Register Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI.PublicControls" TagPrefix="telerik" %>
<%@ Register Assembly="Telerik.Sitefinity" Namespace="Telerik.Sitefinity.Web.UI" TagPrefix="sitefinity" %>
<sitefinity:ResourceLinks ID="resourcesLinks" runat="server" UseEmbeddedThemes="True">
    <sitefinity:ResourceFile AssemblyInfo="NewsRotator.Rotator, NewsRotator" Name="NewsRotator.Resources.Stylesheets.default.css"
        Static="true" />
    <sitefinity:ResourceFile AssemblyInfo="NewsRotator.Rotator, NewsRotator" Name="NewsRotator.Resources.Stylesheets.LeftViewOverlay.css"
        Static="true" />
    <sitefinity:ResourceFile AssemblyInfo="NewsRotator.Rotator, NewsRotator" Name="NewsRotator.Resources.ScrollScript.js" />
</sitefinity:ResourceLinks>
<sf:RadRotator Width="986px" Height="272" ItemWidth="986px" ItemHeight="272" id="RadRotator1"
    runat="server" RotatorType="FromCode">
    <ItemTemplate>
        <asp:Panel runat="server" ID="wrapperDiv" class="Box">

                <asp:Image runat="server" ID="newsImage" Visible="False" />
                    <div class="Image ImageLeftViewOverlay" style="background-image: url('/Images/NewsImage01.jpg')"> 
                        <div class="ArticleBackground ArticleBackgroundLeftViewOverlay"></div>
                        <div class="Article ArticleLeftViewOverlay">
                            <sitefinity:SitefinityLabel runat="server" ID="newsTitle" CssClass="Title" WrapperTagName="h2" />
                            <sitefinity:SitefinityLabel runat="server" ID="newsText" CssClass="Summary" WrapperTagName="div" />
                            <asp:HyperLink runat="server" ID="newsLink" CssClass="btnStretch Link"><span>Read more...</span></asp:HyperLink>
                        </div>
                    </div>
            <div style="clear:both;"></div>
            
        </asp:Panel>
    </ItemTemplate>
</sf:RadRotator>
<asp:Panel runat="server" ID="navigationDiv" class="Navigation">
    <a href="#" onclick="showNextItem(this, $find('<%= RadRotator1.ClientID %>'), Telerik.Web.UI.RotatorScrollDirection.Right); return false;"
        class="rotatorButton rotatorButtonPrev" title="Previous"></a><a href="#" onclick="switchMode(this, $find('<%= RadRotator1.ClientID %>'), Telerik.Web.UI.RotatorScrollDirection.Left); return false;"
            class="rotatorButton rotatorButtonPlay" title="Play" runat="server" id="rotatorPlayButton">
        </a><a href="#" onclick="showNextItem(this, $find('<%= RadRotator1.ClientID %>'), Telerik.Web.UI.RotatorScrollDirection.Left); return false;"
            class="rotatorButton rotatorButtonNext" title="Next"></a>
</asp:Panel>
<div style="clear: both;">
</div>
