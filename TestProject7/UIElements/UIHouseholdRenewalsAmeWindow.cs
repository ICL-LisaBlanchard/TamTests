namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIHouseholdRenewalsAmeWindow : WinWindow
    {
        public UIHouseholdRenewalsAmeWindow()
        {
            #region Search Criteria

            this.windowName = "Household Renewals Amend Risk";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowName;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "52");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UINextWindow
        {
            get
            {
                if ((this.mUINextWindow == null))
                {
                    this.mUINextWindow = new UIItemWindow(this, controlId: "72");
                }
                return this.mUINextWindow;
            }
        }

        public UIItemWindow UINextWindow1
        {
            get
            {
                if ((this.mUINextWindow1 == null))
                {
                    this.mUINextWindow1 = new UIItemWindow(this, controlId: "17");
                }
                return this.mUINextWindow1;
            }
        }

        public UIItemWindow UINextWindow2
        {
            get
            {
                if ((this.mUINextWindow2 == null))
                {
                    this.mUINextWindow2 = new UIItemWindow(this, controlId: "18");
                }
                return this.mUINextWindow2;
            }
        }

        public UIItemWindow UINextWindow3
        {
            get
            {
                if ((this.mUINextWindow3 == null))
                {
                    this.mUINextWindow3 = new UIItemWindow(this, controlId: "36");
                }
                return this.mUINextWindow3;
            }
        }

        public UIItemWindow UINextWindow4
        {
            get
            {
                if ((this.mUINextWindow4 == null))
                {
                    this.mUINextWindow4 = new UIItemWindow(this, controlId: "43");
                }
                return this.mUINextWindow4;
            }
        }

        public UIItemWindow UINextWindow5
        {
            get
            {
                if ((this.mUINextWindow5 == null))
                {
                    this.mUINextWindow5 = new UIItemWindow(this, controlId: "76");
                }
                return this.mUINextWindow5;
            }
        }

        public UIItemWindow UINextWindow6
        {
            get
            {
                if ((this.mUINextWindow6 == null))
                {
                    this.mUINextWindow6 = new UIItemWindow(this, controlId: "75");
                }
                return this.mUINextWindow6;
            }
        }

        public UIItemWindow UIQuoteWindow
        {
            get
            {
                if ((this.mUIQuoteWindow == null))
                {
                    this.mUIQuoteWindow = new UIItemWindow(this, controlId: "141");
                }
                return this.mUIQuoteWindow;
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

        #endregion
    }
}