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

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Specified Items Inside";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Specified Items Inside");

            #endregion
        }

        #region Properties

        public UIItemWindow UINewWindow
        {
            get
            {
                if ((this.mUINewWindow == null))
                {
                    this.mUINewWindow = new UIItemWindow(this, "14");
                }
                return this.mUINewWindow;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, "4");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow(this, "9");
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow(this, "2", "2");
                }
                return this.mUIItemWindow2;
            }
        }

        public UIItemWindow UITxtDescriptionWindow
        {
            get
            {
                if ((this.mUITxtDescriptionWindow == null))
                {
                    this.mUITxtDescriptionWindow = new UIItemWindow(this, "10");
                }
                return this.mUITxtDescriptionWindow;
            }
        }

        public UIItemWindow UISaveWindow
        {
            get
            {
                if ((this.mUISaveWindow == null))
                {
                    this.mUISaveWindow = new UIItemWindow(this, "7");
                }
                return this.mUISaveWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, "3");
                }
                return this.mUIOKWindow;
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