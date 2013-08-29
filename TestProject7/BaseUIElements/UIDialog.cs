namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDialog : WinControl
    {
        public UIDialog(UITestControl searchLimitContainer, string name, string controlType)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = name;
            this.SearchProperties[UITestControl.PropertyNames.ControlType] = controlType;
            this.WindowTitles.Add("Confirm Save As");

            #endregion
        }

        #region Properties

        public WinPane UIConfirmSaveAsPane
        {
            get
            {
                return new UIPane(this, "Confirm Save As");
            }
        }

        #endregion
    }
}