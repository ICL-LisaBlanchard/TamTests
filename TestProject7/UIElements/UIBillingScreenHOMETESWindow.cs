namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBillingScreenHOMETESWindow : WinWindow
    {
        public UIBillingScreenHOMETESWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32770";
            this.WindowTitles.Add("Policy: gdfhdf dfghgdf");

            #endregion
        }

        #region Properties

        public UIItemWindow57 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow57(this);
                }
                return this.mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow57 mUIItemWindow;

        #endregion
    }
}