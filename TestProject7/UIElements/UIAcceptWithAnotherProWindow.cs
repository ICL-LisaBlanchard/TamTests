namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIAcceptWithAnotherProWindow : WinWindow
    {
        public UIAcceptWithAnotherProWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Accept With Another Product";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(WindowName);

            #endregion
        }

        #region Properties

        private const string WindowName = "Accept With Another Product";

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "2");
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
                    this.mUIItemWindow1 = new UIItemWindow(this, controlId: "3");
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
                    this.mUIItemWindow2 = new UIItemWindow(this, controlId: "1");
                }
                return this.mUIItemWindow2;
            }
        }

        public UIItemWindow UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow(this, controlId: "1", instance: "2");
                }
                return this.mUIItemWindow3;
            }
        }

        public UIItemWindow UIItemWindow4
        {
            get
            {
                if ((this.mUIItemWindow4 == null))
                {
                    this.mUIItemWindow4 = new UIItemWindow(this, controlId: "1", instance: "3");
                }
                return this.mUIItemWindow4;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "5");
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIItemWindow2;

        private UIItemWindow mUIItemWindow3;

        private UIItemWindow mUIItemWindow4;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}