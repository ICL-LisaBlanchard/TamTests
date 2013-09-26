namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIRebrokeResultsScreenWindow : WinWindow
    {
        public UIRebrokeResultsScreenWindow()
        {
            #region Search Criteria

            windowName = "Rebroke Results Screen";
            SearchProperties[UITestControl.PropertyNames.Name] = windowName;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowName);

            #endregion
        }

        #region Properties

        public UITestControl UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, instance: "8", className: "msvb_lib_header");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "8");
                }
                return mUIOKWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((mUIItemWindow1 == null))
                {
                    mUIItemWindow1 = new UIItemWindow(this, instance: "8", className: "ListView20WndClass");
                }
                return mUIItemWindow1;
            }
        }

        public UIItemWindow UISelectAlternativeWindow
        {
            get
            {
                if ((mUISelectAlternativeWindow == null))
                {
                    mUISelectAlternativeWindow = new UIItemWindow(this, controlId: "6");
                }
                return mUISelectAlternativeWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName;

        private UITestControl mUIItemWindow;

        private UIItemWindow mUIOKWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUISelectAlternativeWindow;

        #endregion
    }
}