namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UISpecifiedItemsInsideWindow : WinWindow
    {
        public UISpecifiedItemsInsideWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Specified Items Inside";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("Specified Items Inside");

            #endregion
        }

        #region Properties

        public UIItemWindow UINewWindow
        {
            get
            {
                if ((mUINewWindow == null))
                {
                    mUINewWindow = new UIItemWindow(this, "14");
                }
                return mUINewWindow;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, "4");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((mUIItemWindow1 == null))
                {
                    mUIItemWindow1 = new UIItemWindow(this, "9");
                }
                return mUIItemWindow1;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((mUIItemWindow2 == null))
                {
                    mUIItemWindow2 = new UIItemWindow(this, "2", "2");
                }
                return mUIItemWindow2;
            }
        }

        public UIItemWindow UITxtDescriptionWindow
        {
            get
            {
                if ((mUITxtDescriptionWindow == null))
                {
                    mUITxtDescriptionWindow = new UIItemWindow(this, "10");
                }
                return mUITxtDescriptionWindow;
            }
        }

        public UIItemWindow UISaveWindow
        {
            get
            {
                if ((mUISaveWindow == null))
                {
                    mUISaveWindow = new UIItemWindow(this, "7");
                }
                return mUISaveWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, "3");
                }
                return mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUINewWindow;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIItemWindow2;

        private UIItemWindow mUITxtDescriptionWindow;

        private UIItemWindow mUISaveWindow;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}