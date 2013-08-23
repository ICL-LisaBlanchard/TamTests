namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRegistryEditorWindow : WinWindow
    {
        public UIRegistryEditorWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Registry Editor";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Registry Editor");

            #endregion
        }

        #region Properties

        public UIRegistryEditorPane UIRegistryEditorPane
        {
            get
            {
                if ((this.mUIRegistryEditorPane == null))
                {
                    this.mUIRegistryEditorPane = new UIRegistryEditorPane(this);
                }
                return this.mUIRegistryEditorPane;
            }
        }

        public UIRegistryEditorDialog UIRegistryEditorDialog
        {
            get
            {
                if ((this.mUIRegistryEditorDialog == null))
                {
                    this.mUIRegistryEditorDialog = new UIRegistryEditorDialog(this);
                }
                return this.mUIRegistryEditorDialog;
            }
        }

        #endregion

        #region Fields

        private UIRegistryEditorPane mUIRegistryEditorPane;

        private UIRegistryEditorDialog mUIRegistryEditorDialog;

        #endregion
    }
}