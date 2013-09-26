namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPolicyListWindow1 : WinWindow
    {
        private const string WindowTitle = "Policy: autotest";

        #region Properties

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((mUICancelWindow == null))
                {
                    mUICancelWindow = new UIItemWindow(this, controlId: "8");
                }
                return mUICancelWindow;
            }
        }

        public UIItemWindow UIOptionsWindow
        {
            get
            {
                if ((mUIOptionsWindow == null))
                {
                    mUIOptionsWindow = new UIItemWindow(this, controlId: "7");
                }
                return mUIOptionsWindow;
            }
        }

        public UITestControl UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "2");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIDetailWindow
        {
            get
            {
                if ((mUIDetailWindow == null))
                {
                    mUIDetailWindow = new UIItemWindow(this, controlId: "6");
                }
                return mUIDetailWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUICancelWindow;

        private UIItemWindow mUIOptionsWindow;

        private UITestControl mUIItemWindow;

        private UIItemWindow mUIDetailWindow;

        #endregion

        public UIPolicyListWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[WinControl.PropertyNames.ControlId] = "32769";
            WindowTitles.Add(WindowTitle);

            #endregion
        }
    }
}