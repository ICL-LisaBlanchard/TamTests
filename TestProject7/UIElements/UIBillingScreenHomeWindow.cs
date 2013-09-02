namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIBillingScreenHomeWindow : WinWindow
    {
        public UIBillingScreenHomeWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32770";
            this.windowName1 = "Policy: autotest";
            this.WindowTitles.Add(this.windowName1);
            this.windowName2 = "Transaction: autotest";
            this.WindowTitles.Add(this.windowName2);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "1", instance: "25");
                }
                return this.mUIItemWindow;
            }
        }

        public UITestControl UIDetailWindow
        {
            get
            {
                if ((this.mUIDetailWindow == null))
                {
                    this.mUIDetailWindow = new UIItemWindow(this, controlId: "6");
                }
                return this.mUIDetailWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName1;

        private readonly string windowName2;

        private UIItemWindow mUIItemWindow;

        private UITestControl mUIDetailWindow;

        #endregion
    }
}