namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDetailsPanePane : WinPane
    {
        public UIDetailsPanePane(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Details Pane";
            this.WindowTitles.Add("Save the file as");

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