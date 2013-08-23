namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBillingScreenMOTOTESWindow : WinWindow
    {
        public UIBillingScreenMOTOTESWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32770";
            this.WindowTitles.Add("Policy: rty ert");

            #endregion
        }

        #region Properties

        public UIItemWindow27 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow27(this);
                }
                return this.mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow27 mUIItemWindow;

        #endregion
    }
}