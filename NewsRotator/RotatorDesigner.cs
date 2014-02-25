namespace NewsRotator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web.UI;
    using Telerik.Sitefinity.Web.UI;
    using Telerik.Sitefinity.Web.UI.ControlDesign;

    /// <summary>
    /// The control designer class for the Rotator widget
    /// </summary>
    public class RotatorDesigner : ControlDesignerBase
    {
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
                return "NewsRotator.Resources.Views.RotatorDesigner.ascx";
            }
        }

        /// <summary>
        /// Gets a type from the resource assembly.
        /// Resource assembly is an assembly that contains embedded resources such as templates, images, CSS files and etc.
        /// By default this is Telerik.Sitefinity.Resources.dll.
        /// </summary>
        /// <value>The resources assembly info.</value>
        protected override Type ResourcesAssemblyInfo
        {
            get
            {
                return this.GetType();
            }
        }
        
        /// <summary>
        /// Gets a collection of <see cref="T:System.Web.UI.ScriptReference"/> objects that define script resources that the control requires.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerable"/> collection of <see cref="T:System.Web.UI.ScriptReference"/> objects.
        /// </returns>
        public override IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences()
        {
            var res = new List<ScriptReference>(base.GetScriptReferences());
            var assemblyName = this.GetType().Assembly.GetName().ToString();
            res.Add(new ScriptReference("NewsRotator.Resources.RotatorDesigner.js", assemblyName));
            return res.ToArray();
        }
        
        /// <summary>
        /// Initializes the controls.
        /// </summary>
        /// <param name="container">The control container.</param>
        /// <remarks>
        /// Initialize your controls in this method. Do not override CreateChildControls method.
        /// </remarks>
        protected override void InitializeControls(GenericContainer container)
        {
            this.DesignerMode = ControlDesignerModes.Simple;
        }
    }
}
