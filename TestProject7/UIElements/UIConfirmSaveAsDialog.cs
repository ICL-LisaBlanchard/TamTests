namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIConfirmSaveAsDialog : WinControl
    {
        public UIConfirmSaveAsDialog(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Confirm Save As";
            this.SearchProperties[UITestControl.PropertyNames.ControlType] = "Dialog";
            this.WindowTitles.Add("Confirm Save As");

            #endregion
        }

        #region Properties

        public WinPane UIConfirmSaveAsPane
        {
            get
            {
                if ((this.mUIConfirmSaveAsPane == null))
                {
                    this.mUIConfirmSaveAsPane = new WinPane(this);

                    #region Search Criteria

                    this.mUIConfirmSaveAsPane.SearchProperties[UITestControl.PropertyNames.Name] = "Confirm Save As";
                    this.mUIConfirmSaveAsPane.WindowTitles.Add("Confirm Save As");

                    #endregion
                }
                return this.mUIConfirmSaveAsPane;
            }
        }

        #endregion

        #region Fields

        private WinPane mUIConfirmSaveAsPane;

        #endregion
    }
}