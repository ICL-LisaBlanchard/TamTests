namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIHouseholdRenewalsWindow : WinWindow
    {
        public UIHouseholdRenewalsWindow()
        {
            #region Search Criteria

            windowName = "Household Renewals Amend Risk";
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, windowName, PropertyExpressionOperator.Contains));
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
                    mUIItemWindow = new UIItemWindow(this, controlId: "52");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UINextWindow
        {
            get
            {
                if ((mUINextWindow == null))
                {
                    mUINextWindow = new UIItemWindow(this, controlId: "71");
                }
                return mUINextWindow;
            }
        }

        public UIItemWindow UINextWindow1
        {
            get
            {
                if ((mUINextWindow1 == null))
                {
                    mUINextWindow1 = new UIItemWindow(this, controlId: "17");
                }
                return mUINextWindow1;
            }
        }

        public UIItemWindow UINextWindow2
        {
            get
            {
                if ((mUINextWindow2 == null))
                {
                    mUINextWindow2 = new UIItemWindow(this, controlId: "18");
                }
                return mUINextWindow2;
            }
        }

        public UIItemWindow UINextWindow3
        {
            get
            {
                if ((mUINextWindow3 == null))
                {
                    mUINextWindow3 = new UIItemWindow(this, controlId: "36");
                }
                return mUINextWindow3;
            }
        }

        public UIItemWindow UINextWindow4
        {
            get
            {
                if ((mUINextWindow4 == null))
                {
                    mUINextWindow4 = new UIItemWindow(this, controlId: "43");
                }
                return mUINextWindow4;
            }
        }

        public UIItemWindow UINextWindow5
        {
            get
            {
                if ((mUINextWindow5 == null))
                {
                    mUINextWindow5 = new UIItemWindow(this, controlId: "76");
                }
                return mUINextWindow5;
            }
        }

        public UIItemWindow UINextWindow6
        {
            get
            {
                if ((mUINextWindow6 == null))
                {
                    mUINextWindow6 = new UIItemWindow(this, controlId: "75");
                }
                return mUINextWindow6;
            }
        }

        public UIItemWindow UIQuoteWindow
        {
            get
            {
                if ((mUIQuoteWindow == null))
                {
                    mUIQuoteWindow = new UIItemWindow(this, controlId: "141");
                }
                return mUIQuoteWindow;
            }
        }

        public UIItemWindow UIItemWindow7
        {
            get
            {
                if ((mUIItemWindow7 == null))
                {
                    mUIItemWindow7 = new UIItemWindow(this, className: "ListView20WndClass");
                }
                return mUIItemWindow7;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUINextWindow;

        private UIItemWindow mUINextWindow1;

        private UIItemWindow mUINextWindow2;

        private UIItemWindow mUINextWindow3;

        private UIItemWindow mUINextWindow4;

        private UIItemWindow mUINextWindow5;

        private UIItemWindow mUINextWindow6;

        private UIItemWindow mUIQuoteWindow;

        private UIItemWindow mUIItemWindow7;

        #endregion
    }
}