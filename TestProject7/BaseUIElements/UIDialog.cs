namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIDialog : UIItemWindow
    {
        public UIDialog(UITestControl searchLimitContainer, string name, string controlType)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = name;
            SearchProperties[UITestControl.PropertyNames.ControlType] = controlType;
            WindowTitles.Add("Confirm Save As");

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