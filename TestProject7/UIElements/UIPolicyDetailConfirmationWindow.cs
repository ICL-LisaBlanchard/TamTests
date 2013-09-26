namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPolicyDetailConfirmationWindow : WinWindow
    {
        public UIPolicyDetailConfirmationWindow()
        {
            #region Search Criteria

            windowName = "Policy Detail Confirmation";
            SearchProperties[UITestControl.PropertyNames.Name] = windowName;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "1", instance: "2");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UILookupWindow
        {
            get
            {
                if ((mUILookupWindow == null))
                {
                    mUILookupWindow = new UIItemWindow(this, controlId: "8");
                }
                return mUILookupWindow;
            }
        }

        public UIItemWindow UIConfirmWindow
        {
            get
            {
                if ((mUIConfirmWindow == null))
                {
                    mUIConfirmWindow = new UIItemWindow(this, controlId: "5", instance: "2");
                }
                return mUIConfirmWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUILookupWindow;

        private UIItemWindow mUIConfirmWindow;

        #endregion
    }
}