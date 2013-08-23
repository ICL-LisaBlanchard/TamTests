namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIConfirmSaveAsPane : WinPane
    {
        public UIConfirmSaveAsPane(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Confirm Save As";
            this.WindowTitles.Add("Confirm Save As");

            #endregion
        }

        #region Properties

        public WinButton UIYesButton
        {
            get
            {
                if ((this.mUIYesButton == null))
                {
                    this.mUIYesButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIYesButton.SearchProperties[UITestControl.PropertyNames.Name] = "Yes";
                    this.mUIYesButton.WindowTitles.Add("Confirm Save As");

                    #endregion
                }
                return this.mUIYesButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIYesButton;

        #endregion
    }
}