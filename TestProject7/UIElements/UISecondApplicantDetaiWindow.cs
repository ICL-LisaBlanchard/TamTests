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

            SearchProperties[UITestControl.PropertyNames.Name] = "Second Applicant Details";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("Second Applicant Details");

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, "13");
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
                    mUIItemWindow1 = new UIItemWindow(this, "12");
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
                    mUIItemWindow2 = new UIItemWindow(this, "11");
                }
                return mUIItemWindow2;
            }
        }

        public UIItemWindow UIItemWindow3
        {
            get
            {
                if ((mUIItemWindow3 == null))
                {
                    mUIItemWindow3 = new UIItemWindow(this, className: "ThunderRT6UserControlDC");
                }
                return mUIItemWindow3;
            }
        }

        public UIItemWindow UIItemWindow4
        {
            get
            {
                if ((mUIItemWindow4 == null))
                {
                    mUIItemWindow4 = new UIItemWindow(this, "1", "2");
                }
                return mUIItemWindow4;
            }
        }

        public UIItemWindow UIItemWindow5
        {
            get
            {
                if ((mUIItemWindow5 == null))
                {
                    mUIItemWindow5 = new UIItemWindow(this, "9");
                }
                return mUIItemWindow5;
            }
        }

        public UIItemWindow UIItemWindow6
        {
            get
            {
                if ((mUIItemWindow6 == null))
                {
                    mUIItemWindow6 = new UIItemWindow(this, "14");
                }
                return mUIItemWindow6;
            }
        }

        public UIItemWindow UIItemWindow7
        {
            get
            {
                if ((mUIItemWindow7 == null))
                {
                    mUIItemWindow7 = new UIItemWindow(this, "6");
                }
                return mUIItemWindow7;
            }
        }

        public UIItemWindow UIItemWindow8
        {
            get
            {
                if ((mUIItemWindow8 == null))
                {
                    mUIItemWindow8 = new UIItemWindow(this, "5");
                }
                return mUIItemWindow8;
            }
        }

        public UIItemWindow UIItemWindow9
        {
            get
            {
                if ((mUIItemWindow9 == null))
                {
                    mUIItemWindow9 = new UIItemWindow(this, "7");
                }
                return mUIItemWindow9;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, "16");
                }
                return mUIOKWindow;
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