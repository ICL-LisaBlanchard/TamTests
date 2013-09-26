namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIDetailsPanePane : WinPane
    {
        public UIDetailsPanePane(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Details Pane";
            WindowTitles.Add("Save the file as");

            #endregion
        }

        #region Properties

        public WinComboBox UIFilenameComboBox
        {
            get
            {
                return new UIItemComboBox(this, "File name:");
            }
        }

        #endregion
    }
}