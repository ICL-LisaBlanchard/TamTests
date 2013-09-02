namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIMotorQuotesWindow : WinWindow
    {
        public UIMotorQuotesWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32768";

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "2", instance: "3");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UICalculateQuoteWindow
        {
            get
            {
                if ((this.mUICalculateQuoteWindow == null))
                {
                    this.mUICalculateQuoteWindow = new UIItemWindow(this, controlId: "21");
                }
                return this.mUICalculateQuoteWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow(this, controlId: "32");
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow TbxFirstname
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow(this, controlId: "102");
                }
                return this.mUIItemWindow2;
            }
        }

        public UIItemWindow TbxLastName
        {
            get
            {
                if ((this.mUIItemWindow11 == null))
                {
                    this.mUIItemWindow11 = new UIItemWindow(this, controlId: "101");
                }
                return this.mUIItemWindow11;
            }
        }

        public UIItemWindow TbxJobTitle
        {
            get
            {
                if ((this.mUIItemWindow21 == null))
                {
                    this.mUIItemWindow21 = new UIItemWindow(this, controlId: "96");
                }
                return this.mUIItemWindow21;
            }
        }

        public UIItemWindow TbxJobSector
        {
            get
            {
                return new UIItemWindow(this, controlId: "95");
            }
        }

        public UIItemWindow TbxDateOfBirth
        {
            get
            {
                return new UIItemWindow(this, controlId: "1", instance: "2");
            }
        }

        public UIItemWindow TbxPostcode
        {
            get
            {
                return new UIItemWindow(this, controlId: "1", instance: "3");
            }
        }

        public UIItemWindow UILookupWindow
        {
            get
            {
                return new UIItemWindow(this, controlId: "8", instance: "2");
            }
        }

        public UIItemWindow UIItemWindow6
        {
            get
            {
                return new UIItemWindow(this, controlId: "7", instance: "2");
            }
        }

        public UIItemWindow UIItemWindow7
        {
            get
            {
                return new UIItemWindow(this, controlId: "5", instance: "2");
            }
        }

        public UIItemWindow UINextWindow
        {
            get
            {
                return new UIItemWindow(this, controlId: "82");
            }
        }

        public UIItemWindow UIItemWindow8
        {
            get
            {
                return new UIItemWindow(this, controlId: "1", instance: "4");
            }
        }

        public UIItemWindow UINextWindow1
        {
            get
            {
                return new UIItemWindow(this, controlId: "136");
            }
        }

        public UIItemWindow UINextWindow2
        {
            get
            {
                return new UIItemWindow(this, controlId: "135");
            }
        }

        public UIItemWindow UINextWindow3
        {
            get
            {
                return new UIItemWindow(this, controlId: "117");
            }
        }

        public UIItemWindow UIItemWindow22
        {
            get
            {
                return new UIItemWindow(this, controlId: "2", instance: "6");
            }
        }

        public UIItemWindow UIItemWindow32
        {
            get
            {
                return new UIItemWindow(this, controlId: "2", instance: "6");
            }
        }

        public UIItemWindow UINextWindow4
        {
            get
            {
                return new UIItemWindow(this, controlId: "110");
            }
        }

        public UIItemWindow UIItemWindow41
        {
            get
            {
                return new UIItemWindow(this, controlId: "2", instance: "8");
            }
        }

        public UIItemWindow UINextWindow5
        {
            get
            {
                return new UIItemWindow(this, controlId: "77");
            }
        }

        public UIItemWindow UINextWindow6
        {
            get
            {
                return new UIItemWindow(this, controlId: "78");
            }
        }

        public UIItemWindow UIQuoteWindow
        {
            get
            {
                return new UIItemWindow(this, "12");
            }
        }

        public UIItemWindow UIExitWindow
        {
            get
            {
                return new UIItemWindow(this, "22");
            }
        }

        public UIItemWindow UIMTAWindow
        {
            get
            {
                return new UIItemWindow(this, "48");
            }
        }

        public UIItemWindow UICancelWindow
        {
            get
            {
                return new UIItemWindow(this, "83");
            }
        }

        public UIItemWindow UIMTAWindow1
        {
            get
            {
                return new UIItemWindow(this, "81");
            }
        }

        public UITestControl UIItemWindow9
        {
            get
            {
                return new UIItemWindow(this, className: "SSTabCtlWndClass");
            }
        }

        public UIItemWindow UIEDIMatchWindow
        {
            get
            {
                return new UIItemWindow(this, "7");
            }
        }

        public UIItemWindow UILogandClearWindow
        {
            get
            {
                return new UIItemWindow(this, "5");
            }
        }

        public UIItemWindow UIItemWindow10
        {
            get
            {
                return new UIItemWindow(this, className: "ListView20WndClass");
            }
        }

        public UIItemWindow UIDisplayRecordWindow
        {
            get
            {
                return new UIItemWindow(this, "3");
            }
        }

        public UIItemWindow UIFilterWindow
        {
            get
            {
                return new UIItemWindow(this, "9");
            }
        }

        public UIItemWindow UIItemWindow12
        {
            get
            {
                return new UIItemWindow(this, className: "msvb_lib_header");
            }
        }

        public UIItemWindow UIExitWindow1
        {
            get
            {
                return new UIItemWindow(this, "10");
            }
        }

        public UIItemWindow UIItemWindow13
        {
            get
            {
                return new UIItemWindow(this, controlId: "1");
            }
        }

        public UITestControl UICancelWindow1
        {
            get
            {
                return new UIItemWindow(this, "83");
            }
        }

        public UIItemWindow UICancelWindow2
        {
            get
            {
                return new UIItemWindow(this, "11");
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUICalculateQuoteWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIItemWindow2;

        private UIItemWindow mUIItemWindow11;

        private UIItemWindow mUIItemWindow21;

        #endregion
    }
}