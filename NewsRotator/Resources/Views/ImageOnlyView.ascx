<%@ Control Language="C#" %>



<%@ Register Assembly="Telerik.Web.UI, Version=2013.3.1114.40, Culture=neutral, PublicKeyToken=121fae78165ba3d4" Namespace="Telerik.Web.UI" TagPrefix="sf" %>
<%@ Register Assembly="Telerik.Sitefinity, Version=6.3.5000.0, Culture=neutral, PublicKeyToken=b28c218413bdf563" Namespace="Telerik.Sitefinity.Web.UI.PublicControls" TagPrefix="telerik" %>
<%@ Register Assembly="Telerik.Sitefinity, Version=6.3.5000.0, Culture=neutral, PublicKeyToken=b28c218413bdf563" Namespace="Telerik.Sitefinity.Web.UI" TagPrefix="sitefinity" %>
<sitefinity:ResourceLinks ID="resourcesLinks" runat="server" UseEmbeddedThemes="True">
    <sitefinity:ResourceFile AssemblyInfo="NewsRotator.Rotator, NewsRotator" Name="NewsRotator.Resources.Stylesheets.default.css"
        Static="true" />
    <sitefinity:ResourceFile AssemblyInfo="NewsRotator.Rotator, NewsRotator" Name="NewsRotator.Resources.Stylesheets.ImageOnlyView.css"
        Static="true" />
    <sitefinity:ResourceFile AssemblyInfo="NewsRotator.Rotator, NewsRotator" Name="NewsRotator.Resources.ScrollScript.js" />
</sitefinity:ResourceLinks>
<sf:RadRotator id="RadRotator1" runat="server" RotatorType="FromCode">
    <ItemTemplate>
        <asp:Panel runat="server" ID="wrapperDiv" CssClass="Box">
            <asp:Panel runat="server" ID="ImageBackgroundPanel" CssClass="Image ImageImageOnlyView">
                <div class="ArticleBackground ArticleBackgroundImageOnlyView"></div>
                <div class="Article ArticleImageOnlyView">
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
