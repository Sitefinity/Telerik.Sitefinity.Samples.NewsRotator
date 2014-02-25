<%@ Register Assembly="Telerik.Sitefinity, Version=6.3.5000.0, Culture=neutral, PublicKeyToken=b28c218413bdf563" Namespace="Telerik.Sitefinity.Web.UI.ControlDesign" TagPrefix="designers" %>
<%@ Register Assembly="Telerik.Sitefinity, Version=6.3.5000.0, Culture=neutral, PublicKeyToken=b28c218413bdf563" Namespace="Telerik.Sitefinity.Web.UI" TagPrefix="sitefinity" %>
<sitefinity:ResourceLinks ID="resourcesLinks" runat="server" UseEmbeddedThemes="True">
    <sitefinity:ResourceFile AssemblyInfo="NewsRotator.Rotator, NewsRotator" Name="NewsRotator.Resources.Stylesheets.Designer.css"
        Static="true" />
</sitefinity:ResourceLinks>
<%--<h2>Navigation</h2>--%>
<div class="sfContentViews">
    <div class="sfColWrapper sfEqualCols sfModeSelector sfClearfix sfNavDesignerCtrl sfNavDim">
        <div id="RotatorDesignChoice" class="sfLeftCol">
            <h2 class="sfStep1">
                What type of News Rotator to use?</h2>
            <ul class="sfRadioList RotatorDesignList sfNavModes ">
                <li class="ImageOnlyView">
                    <label for="DesImageOnlyView">
                        Image Only</label>
                    <input type="radio" id="DesImageOnlyView" name="RotatorDesign" value="ImageOnlyView" />
                </li>
                <li class="LeftView">
                    <label for="DesLeftView">
                        Left</label>
                    <input type="radio" id="DesLeftView" name="RotatorDesign" value="LeftView" />
                </li>
                <li class="LeftViewOverlay">
                    <label for="DesLeftViewOverlay">
                        Left & Overlay</label>
                    <input type="radio" id="DesLeftViewOverlay" name="RotatorDesign" value="LeftViewOverlay" />
                </li>
                <li class="RightView">
                    <label for="DesRightView">
                        Right</label>
                    <input type="radio" id="DesRightView" name="RotatorDesign" value="RightView" />
                </li>
                <li class="RightViewOverlay">
                    <label for="DesRightViewOverlay">
                        Right & Overlay</label>
                    <input type="radio" id="DesRightViewOverlay" name="RotatorDesign" value="RightViewOverlay" />
                </li>
                <li class="WideView">
                    <label for="DesWideView">
                        Wide</label>
                    <input type="radio" id="DesWideView" name="RotatorDesign" value="WideView" />
                </li>
                <li class="WideViewOverlay">
                    <label for="DesWideViewOverlay">
                        Wide & Overlay</label>
                    <input type="radio" id="DesWideViewOverlay" name="RotatorDesign" value="WideViewOverlay" />
                </li>
            </ul>
        </div>
        <div id="RotatorOptions" class="sfRightCol">
            <h2 class="sfStep2">
                Fine tune your Rotator</h2>
            <div class="sfStep2Options">
                <div id="groupSettingPageSelect">
                    <div id="" class="sfExpandableSection">
                        <h3>
                            <a href="javascript:void(0);" class="sfMoreDetails" id="A3">Layout</a></h3>
                        <ul class="sfTargetList">
                            <li>
                                <label for="RotatorWidth" class="sfTxtLbl">
                                    Width</label>
                                <input type="text" id="RotatorWidth" class="sfTxt" />
                            </li>
                            <li>
                                <label for="RotatorHeight" class="sfTxtLbl">
                                    Height</label>
                                <input type="text" id="RotatorHeight" class="sfTxt" />
                            </li>
                            <li>
                                <label for="RotatorItemWidth" class="sfTxtLbl">
                                    Item Width</label>
                                <input type="text" id="RotatorItemWidth" class="sfTxt" />
                            </li>
                            <li>
                                <label for="RotatorItemHeight" class="sfTxtLbl">
                                    Item Height</label>
                                <input type="text" id="RotatorItemHeight" class="sfTxt" />
                            </li>
                            <li>
                                <label for="RotatorItemHeight" class="sfTxtLbl">
                                    Display Time</label>
                                <input type="text" id="RotatorDisplayTime" class="sfTxt" />
                            </li>
                        </ul>
                    </div>
                    <div id="" class="sfExpandableSection">
                        <h3>
                            <a href="javascript:void(0);" class="sfMoreDetails" id="A1">Transition Settings</a></h3>
                        <ul class="sfTargetList">
                            <li>
                                <label for="RotatorTransitionTime" class="sfTxtLbl">
                                    Transition Time</label>
                                <input type="text" id="RotatorTransitionTime" class="sfTxt" />
                            </li>
                        </ul>
                    </div>
                    <div id="" class="sfExpandableSection">
                        <h3>
                            <a href="javascript:void(0);" class="sfMoreDetails" id="A2">News Options</a></h3>
                        <ul class="sfTargetList">
                            <li>
                                <label for="RotatorNewsLimit" class="sfTxtLbl">
                                    News Limit</label>
                                <input type="text" id="RotatorNewsLimit" class="sfTxt" />
                            </li>
                            <li>
                                <label for="RotatorNewsProviderName" class="sfTxtLbl">
                                    Provider Name</label>
                                <input type="text" id="RotatorNewsProviderName" class="sfTxt" />
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>