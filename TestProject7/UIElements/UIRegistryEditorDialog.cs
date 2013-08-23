namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRegistryEditorDialog : WinControl
    {
        public UIRegistryEditorDialog(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Registry Editor";
            this.SearchProperties[UITestControl.PropertyNames.ControlType] = "Dialog";
            this.WindowTitles.Add("Registry Editor");

            #endregion
        }

        #region Properties

        public WinPane UIRegistryEditorPane
        {
            get
            {
                if ((this.mUIRegistryEditorPane == null))
                {
                    this.mUIRegistryEditorPane = new WinPane(this);

                    #region Search Criteria

                    this.mUIRegistryEditorPane.SearchProperties[UITestControl.PropertyNames.Name] = "Registry Editor";
                    this.mUIRegistryEditorPane.WindowTitles.Add("Registry Editor");

                    #endregion
                }
                return this.mUIRegistryEditorPane;
            }
        }

        #endregion

        #region Fields

        private WinPane mUIRegistryEditorPane;

        #endregion
    }
}