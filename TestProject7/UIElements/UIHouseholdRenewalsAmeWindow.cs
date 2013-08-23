namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIHouseholdRenewalsAmeWindow : WinWindow
    {
        public UIHouseholdRenewalsAmeWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Household Renewals Amend Risk";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Household Renewals Amend Risk");

            #endregion
        }

        #region Properties

        public UIItemWindow72 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow72(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UINextWindow7 UINextWindow
        {
            get
            {
                if ((this.mUINextWindow == null))
                {
                    this.mUINextWindow = new UINextWindow7(this);
                }
                return this.mUINextWindow;
            }
        }

        public UINextWindow11 UINextWindow1
        {
            get
            {
                if ((this.mUINextWindow1 == null))
                {
                    this.mUINextWindow1 = new UINextWindow11(this);
                }
                return this.mUINextWindow1;
            }
        }

        public UINextWindow21 UINextWindow2
        {
            get
            {
                if ((this.mUINextWindow2 == null))
                {
                    this.mUINextWindow2 = new UINextWindow21(this);
                }
                return this.mUINextWindow2;
            }
        }

        public UINextWindow31 UINextWindow3
        {
            get
            {
                if ((this.mUINextWindow3 == null))
                {
                    this.mUINextWindow3 = new UINextWindow31(this);
                }
                return this.mUINextWindow3;
            }
        }

        public UINextWindow41 UINextWindow4
        {
            get
            {
                if ((this.mUINextWindow4 == null))
                {
                    this.mUINextWindow4 = new UINextWindow41(this);
                }
                return this.mUINextWindow4;
            }
        }

        public UINextWindow51 UINextWindow5
        {
            get
            {
                if ((this.mUINextWindow5 == null))
                {
                    this.mUINextWindow5 = new UINextWindow51(this);
                }
                return this.mUINextWindow5;
            }
        }

        public UINextWindow61 UINextWindow6
        {
            get
            {
                if ((this.mUINextWindow6 == null))
                {
                    this.mUINextWindow6 = new UINextWindow61(this);
                }
                return this.mUINextWindow6;
            }
        }

        public UIQuoteWindow1 UIQuoteWindow
        {
            get
            {
                if ((this.mUIQuoteWindow == null))
                {
                    this.mUIQuoteWindow = new UIQuoteWindow1(this);
                }
                return this.mUIQuoteWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow72 mUIItemWindow;

        private UINextWindow7 mUINextWindow;

        private UINextWindow11 mUINextWindow1;

        private UINextWindow21 mUINextWindow2;

        private UINextWindow31 mUINextWindow3;

        private UINextWindow41 mUINextWindow4;

        private UINextWindow51 mUINextWindow5;

        private UINextWindow61 mUINextWindow6;

        private UIQuoteWindow1 mUIQuoteWindow;

        #endregion
    }
}