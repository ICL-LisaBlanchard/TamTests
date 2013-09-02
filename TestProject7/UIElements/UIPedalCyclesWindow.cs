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

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Pedal Cycles";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Pedal Cycles");

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, "9");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UINewWindow
        {
            get
            {
                if ((this.mUINewWindow == null))
                {
                    this.mUINewWindow = new UIItemWindow(this, "4");
                }
                return this.mUINewWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow(this, "2", "2");
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow UITxtModelWindow
        {
            get
            {
                if ((this.mUITxtModelWindow == null))
                {
                    this.mUITxtModelWindow = new UIItemWindow(this, "8");
                }
                return this.mUITxtModelWindow;
            }
        }

        public UIItemWindow UITxtSerialNumberWindow
        {
            get
            {
                if ((this.mUITxtSerialNumberWindow == null))
                {
                    this.mUITxtSerialNumberWindow = new UIItemWindow(this, "7");
                }
                return this.mUITxtSerialNumberWindow;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow(this, "10");
                }
                return this.mUIItemWindow2;
            }
        }

        public UIItemWindow UISaveWindow
        {
            get
            {
                if ((this.mUISaveWindow == null))
                {
                    this.mUISaveWindow = new UIItemWindow(this, "11");
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
                    this.mUIOKWindow = new UIItemWindow(this, "14");
                }
                return this.mUIOKWindow;
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