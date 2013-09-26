namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIQuotesWindow : WinWindow
    {
        public UIQuotesWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[WinControl.PropertyNames.ControlId] = "32768";
            WindowTitles.Add("Personal Lines");

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "2", instance: "3");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UICalculateQuoteWindow
        {
            get
            {
                if ((mUICalculateQuoteWindow == null))
                {
                    mUICalculateQuoteWindow = new UIItemWindow(this, controlId: "21");
                }
                return mUICalculateQuoteWindow;
            }
        }

        public UIItemWindow UICarRegistrationWindow
        {
            get
            {
                if ((mUIItemWindow1 == null))
                {
                    mUIItemWindow1 = new UIItemWindow(this, controlId: "32");
                }
                return mUIItemWindow1;
            }
        }

        public UIItemWindow TbxFirstname
        {
            get
            {
                if ((mUIItemWindow2 == null))
                {
                    mUIItemWindow2 = new UIItemWindow(this, controlId: "102");
                }
                return mUIItemWindow2;
            }
        }

        public UIItemWindow TbxLastName
        {
            get
            {
                if ((mUIItemWindow11 == null))
                {
                    mUIItemWindow11 = new UIItemWindow(this, controlId: "101");
                }
                return mUIItemWindow11;
            }
        }

        public UIItemWindow TbxJobTitle
        {
            get
            {
                if ((mUIItemWindow21 == null))
                {
                    mUIItemWindow21 = new UIItemWindow(this, controlId: "96");
                }
                return mUIItemWindow21;
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