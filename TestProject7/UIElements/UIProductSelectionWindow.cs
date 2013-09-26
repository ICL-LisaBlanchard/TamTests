namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIProductSelectionWindow : WinWindow
    {
        public UIProductSelectionWindow()
        {
            #region Search Criteria

            windowTitle = "Product Selection";
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
                    mUIOKWindow = new UIItemWindow(this, controlId: "1");
                }
                return mUIOKWindow;
            }
        }

        public UIItemWindow UIHouseholdWindow
        {
            get
            {
                if ((mUIHouseholdWindow == null))
                {
                    mUIHouseholdWindow = new UIItemWindow(this, controlId: "7");
                }
                return mUIHouseholdWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIOKWindow;

        private UIItemWindow mUIHouseholdWindow;

        #endregion
    }
}