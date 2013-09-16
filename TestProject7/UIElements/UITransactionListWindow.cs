namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UITransactionListWindow : WinWindow
    {
        public UITransactionListWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32771";
            this.WindowTitles.Add("Transaction: autotest");

            #endregion
        }

        #region Properties

        public UIItemWindow UIDetailWindow
        {
            get
            {
                if ((this.mUIDetailWindow == null))
                {
                    this.mUIDetailWindow = new UIItemWindow(this, "6");
                }
                return this.mUIDetailWindow;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, className: "ListView20WndClass");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIOptionsWindow
        {
            get
            {
                if ((this.mUIOptionsWindow == null))
                {
                    this.mUIOptionsWindow = new UIItemWindow(this, "7");
                }
                return this.mUIOptionsWindow;
            }
        }

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((this.mUIOptionsWindow == null))
                {
                    this.mUIOptionsWindow = new UIItemWindow(this, "8");
                }
                return this.mUIOptionsWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIDetailWindow;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIOptionsWindow;

        #endregion
    }
}