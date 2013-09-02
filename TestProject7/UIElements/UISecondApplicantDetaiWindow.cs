namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UISecondApplicantDetaiWindow : WinWindow
    {
        public UISecondApplicantDetaiWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Second Applicant Details";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Second Applicant Details");

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, "13");
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
                    this.mUIItemWindow1 = new UIItemWindow(this, "12");
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
                    this.mUIItemWindow2 = new UIItemWindow(this, "11");
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
                    this.mUIItemWindow3 = new UIItemWindow(this, className: "ThunderRT6UserControlDC");
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
                    this.mUIItemWindow4 = new UIItemWindow(this, "1", "2");
                }
                return this.mUIItemWindow4;
            }
        }

        public UIItemWindow UIItemWindow5
        {
            get
            {
                if ((this.mUIItemWindow5 == null))
                {
                    this.mUIItemWindow5 = new UIItemWindow(this, "9");
                }
                return this.mUIItemWindow5;
            }
        }

        public UIItemWindow UIItemWindow6
        {
            get
            {
                if ((this.mUIItemWindow6 == null))
                {
                    this.mUIItemWindow6 = new UIItemWindow(this, "14");
                }
                return this.mUIItemWindow6;
            }
        }

        public UIItemWindow UIItemWindow7
        {
            get
            {
                if ((this.mUIItemWindow7 == null))
                {
                    this.mUIItemWindow7 = new UIItemWindow(this, "6");
                }
                return this.mUIItemWindow7;
            }
        }

        public UIItemWindow UIItemWindow8
        {
            get
            {
                if ((this.mUIItemWindow8 == null))
                {
                    this.mUIItemWindow8 = new UIItemWindow(this, "5");
                }
                return this.mUIItemWindow8;
            }
        }

        public UIItemWindow UIItemWindow9
        {
            get
            {
                if ((this.mUIItemWindow9 == null))
                {
                    this.mUIItemWindow9 = new UIItemWindow(this, "7");
                }
                return this.mUIItemWindow9;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, "16");
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

        private UIItemWindow mUIItemWindow5;

        private UIItemWindow mUIItemWindow6;

        private UIItemWindow mUIItemWindow7;

        private UIItemWindow mUIItemWindow8;

        private UIItemWindow mUIItemWindow9;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}