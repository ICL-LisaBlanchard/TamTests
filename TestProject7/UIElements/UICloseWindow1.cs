namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICloseWindow1 : WinWindow
    {
        public UICloseWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlName] = "btnExit";
            this.WindowTitles.Add("Transaction List");

            #endregion
        }

        #region Properties

        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);

                    #region Search Criteria

                    this.mUICloseButton.SearchProperties[UITestControl.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Transaction List");

                    #endregion
                }
                return this.mUICloseButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUICloseButton;

        #endregion
    }
}