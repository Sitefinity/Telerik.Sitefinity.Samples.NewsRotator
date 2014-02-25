/// <reference name="MicrosoftAjax.js"/>
/// <reference name="Telerik.Sitefinity.Resources.Scripts.jquery-1.3.2.min-vsdoc2.js" assembly="Telerik.Sitefinity.Resources"/>
Type.registerNamespace("NewsRotator");

NewsRotator.RotatorDesigner = function (element) {
    NewsRotator.RotatorDesigner.initializeBase(this, [element]);

    this._parentDesigner = null;
    this._googleAnalyticsCodeTextField = null;
    this._scriptEmbedPositionChoiceField = null;
    this._toogleGroupSettingsDelegate = null;
}

NewsRotator.RotatorDesigner.prototype = {
    /* --------------------------------- set up and tear down --------------------------------- */
    
    initialize: function () {
        NewsRotator.RotatorDesigner.callBaseMethod(this, 'initialize');
                
        this._toogleGroupSettingsDelegate = Function.createDelegate(this, function () {
            dialogBase.resizeToContent();
        });

        //jQuery("#expanderDesignSettings").click(this._toogleDesignSettingsDelegate);
        jQuery(".sfExpandableSection a").click(this._toogleGroupSettingsDelegate).click(function(){
        $(this).parents(".sfExpandableSection:first").toggleClass("sfExpandedSection");
        });

        this._onLoadDelegate = Function.createDelegate(this, function () {
            dialogBase.resizeToContent();
        });
        Sys.Application.add_load(this._onLoadDelegate);
    },

    dispose: function () {
        NewsRotator.RotatorDesigner.callBaseMethod(this, 'dispose');
    },

    /* --------------------------------- public methods --------------------------------- */
    // implementation of IControlDesigner: Forces the control to refersh from the control Data
    refreshUI: function () {
        //this._refreshMode = true;
        var data = this.get_controlData();
        jQuery("#RotatorWidth").val(data.Width);
        jQuery("#RotatorHeight").val(data.Height);
        jQuery("#RotatorItemWidth").val(data.ItemWidth);
        jQuery("#RotatorItemHeight").val(data.ItemHeight);
        jQuery("#RotatorDisplayTime").val(data.FrameDuration);
        jQuery("#RotatorTransitionTime").val(data.ScrollDuration);
        jQuery("#RotatorNewsLimit").val(data.NewsLimit);
        jQuery("#RotatorNewsProviderName").val(data.ProviderName);

        this._clickRadioChoice("RotatorDesign", data.RotatorDesign);
    },

    // implementation of IControlDesigner: forces the designer view to apply the changes on UI to the control Data
    applyChanges: function () {

        var controlData = this.get_controlData();
        controlData.RotatorDesign = this._getSelectedChoice("RotatorDesign");

        controlData.Width = jQuery("#RotatorWidth").val();
        controlData.Height = jQuery("#RotatorHeight").val();
        controlData.ItemWidth = jQuery("#RotatorItemWidth").val();
        controlData.ItemHeight = jQuery("#RotatorItemHeight").val();
        controlData.FrameDuration = jQuery("#RotatorDisplayTime").val();
        controlData.ScrollDuration = jQuery("#RotatorTransitionTime").val();
        controlData.NewsLimit = jQuery("#RotatorNewsLimit").val();
        controlData.ProviderName = jQuery("#RotatorNewsProviderName").val();

    },
    get_controlData: function () {
        return this.get_propertyEditor().get_control();
    },
    _getSelectedChoice: function (groupName) {
        return jQuery(this.get_element()).find("input[name='" + groupName + "']:checked").val();
    },
    _clickRadioChoice: function (groupName, value) {
        return jQuery(this.get_element()).find("input[name='" + groupName + "'][value='" + value + "']").click();
    },

    /* --------------------------------- event handlers --------------------------------- */
    
    /* --------------------------------- private methods --------------------------------- */

    /* --------------------------------- properties --------------------------------- */

    // gets the reference to the propertyEditor control
    get_propertyEditor: function () {
        return this._propertyEditor;
    },
    // sets the reference fo the propertyEditor control
    set_propertyEditor: function (value) {
        this._propertyEditor = value;
    }

    //get_googleAnalyticsCodeTextField: function () { return this._googleAnalyticsCodeTextField; },
    //set_googleAnalyticsCodeTextField: function (value) { this._googleAnalyticsCodeTextField = value; }
}

NewsRotator.RotatorDesigner.registerClass('NewsRotator.RotatorDesigner', Telerik.Sitefinity.Web.UI.ControlDesign.ControlDesignerBase);

if (typeof (Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();