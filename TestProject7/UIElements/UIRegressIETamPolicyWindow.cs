namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIRegressIETamPolicyWindow : WinWindow
    {
        public UIRegressIETamPolicyWindow()
        {
            #region Search Criteria

            windowName = "Regress IETam Policy";
            SearchProperties[UITestControl.PropertyNames.Name] = windowName;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "8");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((mUIItemWindow2 == null))
                {
                    mUIItemWindow2 = new UIItemWindow(this, controlId: "11");
                }
                return mUIItemWindow2;
            }
        }

        public UIItemWindow UIRegressWindow
        {
            get
            {
                if ((mUIRegressWindow == null))
                {
                    mUIRegressWindow = new UIItemWindow(this, controlId: "10");
                }
                return mUIRegressWindow;
            }
        }

        public UIItemWindow UIExitWindow
        {
            get
            {
                if ((mUIExitWindow == null))
                {
                    mUIExitWindow = new UIItemWindow(this, controlId: "12");
                }
                return mUIExitWindow;
            }
        }

        public UIItemWindow UIItemWindow3
        {
            get
            {
                if ((mUIItemWindow3 == null))
                {
                    mUIItemWindow3 = new UIItemWindow(this, controlId: "9");
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
                    mUIItemWindow4 = new UIItemWindow(this, controlId: "3");
                }
                return mUIItemWindow4;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIItemWindow2;

        private UIItemWindow mUIRegressWindow;

        private UIItemWindow mUIExitWindow;

        private UIItemWindow mUIItemWindow3;

        private UIItemWindow mUIItemWindow4;

        #endregion
    }
}