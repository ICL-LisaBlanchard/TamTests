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

            SearchProperties[WinControl.PropertyNames.ControlId] = "32771";
            WindowTitles.Add("Transaction: autotest");

            #endregion
        }

        #region Properties

        public UIItemWindow UIDetailWindow
        {
            get
            {
                if ((mUIDetailWindow == null))
                {
                    mUIDetailWindow = new UIItemWindow(this, "6");
                }
                return mUIDetailWindow;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, className: "ListView20WndClass");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIOptionsWindow
        {
            get
            {
                if ((mUIOptionsWindow == null))
                {
                    mUIOptionsWindow = new UIItemWindow(this, "7");
                }
                return mUIOptionsWindow;
            }
        }

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((mUIOptionsWindow == null))
                {
                    mUIOptionsWindow = new UIItemWindow(this, "8");
                }
                return mUIOptionsWindow;
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