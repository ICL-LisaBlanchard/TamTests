namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBillingScreenHOMEWindow1 : WinWindow
    {
        public UIBillingScreenHOMEWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32770";
            this.WindowTitles.Add("Policy: autotest");
            this.WindowTitles.Add("Transaction: autotest");

            #endregion
        }

        #region Properties

        public UIItemWindow36 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow36(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIDetailWindow3 UIDetailWindow
        {
            get
            {
                if ((this.mUIDetailWindow == null))
                {
                    this.mUIDetailWindow = new UIDetailWindow3(this);
                }
                return this.mUIDetailWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow36 mUIItemWindow;

        private UIDetailWindow3 mUIDetailWindow;

        #endregion
    }
}