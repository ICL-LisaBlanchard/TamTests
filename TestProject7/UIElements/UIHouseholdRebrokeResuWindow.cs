namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIHouseholdRebrokeResuWindow : WinWindow
    {
        public UIHouseholdRebrokeResuWindow()
        {
            #region Search Criteria

            windowTitle = "Household Rebroke Results";
            SearchProperties[UITestControl.PropertyNames.Name] = windowTitle;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "10");
                }
                return mUIOKWindow;
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

        public UIItemWindow UISelectAlternativeWindow
        {
            get
            {
                if ((mUISelectAlternativeWindow == null))
                {
                    mUISelectAlternativeWindow = new UIItemWindow(this, controlId: "12");
                }
                return mUISelectAlternativeWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIOKWindow;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUISelectAlternativeWindow;

        #endregion
    }
}