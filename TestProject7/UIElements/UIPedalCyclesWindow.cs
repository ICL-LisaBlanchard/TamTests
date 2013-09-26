namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPedalCyclesWindow : WinWindow
    {
        public UIPedalCyclesWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Pedal Cycles";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("Pedal Cycles");

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, "9");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UINewWindow
        {
            get
            {
                if ((mUINewWindow == null))
                {
                    mUINewWindow = new UIItemWindow(this, "4");
                }
                return mUINewWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((mUIItemWindow1 == null))
                {
                    mUIItemWindow1 = new UIItemWindow(this, "2", "2");
                }
                return mUIItemWindow1;
            }
        }

        public UIItemWindow UITxtModelWindow
        {
            get
            {
                if ((mUITxtModelWindow == null))
                {
                    mUITxtModelWindow = new UIItemWindow(this, "8");
                }
                return mUITxtModelWindow;
            }
        }

        public UIItemWindow UITxtSerialNumberWindow
        {
            get
            {
                if ((mUITxtSerialNumberWindow == null))
                {
                    mUITxtSerialNumberWindow = new UIItemWindow(this, "7");
                }
                return mUITxtSerialNumberWindow;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((mUIItemWindow2 == null))
                {
                    mUIItemWindow2 = new UIItemWindow(this, "10");
                }
                return mUIItemWindow2;
            }
        }

        public UIItemWindow UISaveWindow
        {
            get
            {
                if ((mUISaveWindow == null))
                {
                    mUISaveWindow = new UIItemWindow(this, "11");
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
                    mUIOKWindow = new UIItemWindow(this, "14");
                }
                return mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUINewWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUITxtModelWindow;

        private UIItemWindow mUITxtSerialNumberWindow;

        private UIItemWindow mUIItemWindow2;

        private UIItemWindow mUISaveWindow;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}