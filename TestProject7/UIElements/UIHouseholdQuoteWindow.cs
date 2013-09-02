namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIHouseholdQuoteWindow : WinWindow
    {
        public UIHouseholdQuoteWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32768";
            this.WindowTitles.Add("Personal Lines");

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, "86");
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
                    this.mUIItemWindow1 = new UIItemWindow(this, "85");
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow UIIstheapplicationinjoWindow
        {
            get
            {
                if ((this.mUIIstheapplicationinjoWindow == null))
                {
                    this.mUIIstheapplicationinjoWindow = new UIItemWindow(this, "91");
                }
                return this.mUIIstheapplicationinjoWindow;
            }
        }

        public UIItemWindow UIOtherpersonWindow
        {
            get
            {
                if ((this.mUIOtherpersonWindow == null))
                {
                    this.mUIOtherpersonWindow = new UIItemWindow(this, "90");
                }
                return this.mUIOtherpersonWindow;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow(this, "106");
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
                    this.mUIItemWindow3 = new UIItemWindow(this, "2", "11");
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
                    this.mUIItemWindow4 = new UIItemWindow(this, "2", "12");
                }
                return this.mUIItemWindow4;
            }
        }

        public UIItemWindow UINextWindow
        {
            get
            {
                if ((this.mUINextWindow == null))
                {
                    this.mUINextWindow = new UIItemWindow(this, "82");
                }
                return this.mUINextWindow;
            }
        }

        public UIItemWindow UIItemWindow5
        {
            get
            {
                if ((this.mUIItemWindow5 == null))
                {
                    this.mUIItemWindow5 = new UIItemWindow(this, "2", "13");
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
                    this.mUIItemWindow6 = new UIItemWindow(this, "143");
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
                    this.mUIItemWindow7 = new UIItemWindow(this, "144");
                }
                return this.mUIItemWindow7;
            }
        }

        public UIItemWindow UIAreyouafirsttimebuyeWindow
        {
            get
            {
                if ((this.mUIAreyouafirsttimebuyeWindow == null))
                {
                    this.mUIAreyouafirsttimebuyeWindow = new UIItemWindow(this, "145");
                }
                return this.mUIAreyouafirsttimebuyeWindow;
            }
        }

        public UIItemWindow UIItemWindow8
        {
            get
            {
                if ((this.mUIItemWindow8 == null))
                {
                    this.mUIItemWindow8 = new UIItemWindow(this, "1", "4");
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
                    this.mUIItemWindow9 = new UIItemWindow(this, "152");
                }
                return this.mUIItemWindow9;
            }
        }

        public UIItemWindow UIItemWindow10
        {
            get
            {
                if ((this.mUIItemWindow10 == null))
                {
                    this.mUIItemWindow10 = new UIItemWindow(this, "151");
                }
                return this.mUIItemWindow10;
            }
        }

        public UIItemWindow UIDoesanypartofthepropWindow
        {
            get
            {
                if ((this.mUIDoesanypartofthepropWindow == null))
                {
                    this.mUIDoesanypartofthepropWindow = new UIItemWindow(this, "149");
                }
                return this.mUIDoesanypartofthepropWindow;
            }
        }

        public UIItemWindow UIItemWindow11
        {
            get
            {
                if ((this.mUIItemWindow11 == null))
                {
                    this.mUIItemWindow11 = new UIItemWindow(this, "2", "15");
                }
                return this.mUIItemWindow11;
            }
        }

        public UIItemWindow UINextWindow1
        {
            get
            {
                if ((this.mUINextWindow1 == null))
                {
                    this.mUINextWindow1 = new UIItemWindow(this, "136");
                }
                return this.mUINextWindow1;
            }
        }

        public UIItemWindow UIDoesthepropertyhaveaWindow
        {
            get
            {
                if ((this.mUIDoesthepropertyhaveaWindow == null))
                {
                    this.mUIDoesthepropertyhaveaWindow = new UIItemWindow(this, "127");
                }
                return this.mUIDoesthepropertyhaveaWindow;
            }
        }

        public UIItemWindow UIArethereapprovedlockWindow
        {
            get
            {
                if ((this.mUIArethereapprovedlockWindow == null))
                {
                    this.mUIArethereapprovedlockWindow = new UIItemWindow(this, "126");
                }
                return this.mUIArethereapprovedlockWindow;
            }
        }

        public UIItemWindow UIArethereapprovedlockWindow1
        {
            get
            {
                if ((this.mUIArethereapprovedlockWindow1 == null))
                {
                    this.mUIArethereapprovedlockWindow1 = new UIItemWindow(this, "125");
                }
                return this.mUIArethereapprovedlockWindow1;
            }
        }

        public UIItemWindow UIDoesthepropertyhaveaWindow1
        {
            get
            {
                if ((this.mUIDoesthepropertyhaveaWindow1 == null))
                {
                    this.mUIDoesthepropertyhaveaWindow1 = new UIItemWindow(this, "124");
                }
                return this.mUIDoesthepropertyhaveaWindow1;
            }
        }

        public UIItemWindow UIArethereapprovedlockWindow2
        {
            get
            {
                if ((this.mUIArethereapprovedlockWindow2 == null))
                {
                    this.mUIArethereapprovedlockWindow2 = new UIItemWindow(this, "123");
                }
                return this.mUIArethereapprovedlockWindow2;
            }
        }

        public UIItemWindow UIDoesthepropertyhaveaWindow2
        {
            get
            {
                if ((this.mUIDoesthepropertyhaveaWindow2 == null))
                {
                    this.mUIDoesthepropertyhaveaWindow2 = new UIItemWindow(this, "122");
                }
                return this.mUIDoesthepropertyhaveaWindow2;
            }
        }

        public UIItemWindow UIArethereapprovedlockWindow3
        {
            get
            {
                if ((this.mUIArethereapprovedlockWindow3 == null))
                {
                    this.mUIArethereapprovedlockWindow3 = new UIItemWindow(this, "121");
                }
                return this.mUIArethereapprovedlockWindow3;
            }
        }

        public UIItemWindow UIDoesthepropertyhaveaWindow3
        {
            get
            {
                if ((this.mUIDoesthepropertyhaveaWindow3 == null))
                {
                    this.mUIDoesthepropertyhaveaWindow3 = new UIItemWindow(this, "120");
                }
                return this.mUIDoesthepropertyhaveaWindow3;
            }
        }

        public UIItemWindow UIArethereapprovedlockWindow4
        {
            get
            {
                if ((this.mUIArethereapprovedlockWindow4 == null))
                {
                    this.mUIArethereapprovedlockWindow4 = new UIItemWindow(this, "119");
                }
                return this.mUIArethereapprovedlockWindow4;
            }
        }

        public UIItemWindow UINextWindow2
        {
            get
            {
                if ((this.mUINextWindow2 == null))
                {
                    this.mUINextWindow2 = new UIItemWindow(this, "135");
                }
                return this.mUINextWindow2;
            }
        }

        public UIItemWindow UIIncludedinaNeighbourWindow
        {
            get
            {
                if ((this.mUIIncludedinaNeighbourWindow == null))
                {
                    this.mUIIncludedinaNeighbourWindow = new UIItemWindow(this, "21");
                }
                return this.mUIIncludedinaNeighbourWindow;
            }
        }

        public UIItemWindow UIDoesthepropertyhavesWindow
        {
            get
            {
                if ((this.mUIDoesthepropertyhavesWindow == null))
                {
                    this.mUIDoesthepropertyhavesWindow = new UIItemWindow(this, "17");
                }
                return this.mUIDoesthepropertyhavesWindow;
            }
        }

        public UIItemWindow UIDoesthepropertyhaveaWindow4
        {
            get
            {
                if ((this.mUIDoesthepropertyhaveaWindow4 == null))
                {
                    this.mUIDoesthepropertyhaveaWindow4 = new UIItemWindow(this, "16");
                }
                return this.mUIDoesthepropertyhaveaWindow4;
            }
        }

        public UIItemWindow UIIsthereanalarmmainteWindow
        {
            get
            {
                if ((this.mUIIsthereanalarmmainteWindow == null))
                {
                    this.mUIIsthereanalarmmainteWindow = new UIItemWindow(this, "15");
                }
                return this.mUIIsthereanalarmmainteWindow;
            }
        }

        public UIItemWindow UIDoesthepropertyhaveaWindow5
        {
            get
            {
                if ((this.mUIDoesthepropertyhaveaWindow5 == null))
                {
                    this.mUIDoesthepropertyhaveaWindow5 = new UIItemWindow(this, "14");
                }
                return this.mUIDoesthepropertyhaveaWindow5;
            }
        }

        public UIItemWindow UIItemWindow12
        {
            get
            {
                if ((this.mUIItemWindow12 == null))
                {
                    this.mUIItemWindow12 = new UIItemWindow(this, "22");
                }
                return this.mUIItemWindow12;
            }
        }

        public UIItemWindow UIItemWindow13
        {
            get
            {
                if ((this.mUIItemWindow13 == null))
                {
                    this.mUIItemWindow13 = new UIItemWindow(this, "23");
                }
                return this.mUIItemWindow13;
            }
        }

        public UIItemWindow UINextWindow3
        {
            get
            {
                if ((this.mUINextWindow3 == null))
                {
                    this.mUINextWindow3 = new UIItemWindow(this, "117");
                }
                return this.mUINextWindow3;
            }
        }

        public UIItemWindow UIItemWindow14
        {
            get
            {
                if ((this.mUIItemWindow14 == null))
                {
                    this.mUIItemWindow14 = new UIItemWindow(this, "2", "3");
                }
                return this.mUIItemWindow14;
            }
        }

        public UIItemWindow UIItemWindow15
        {
            get
            {
                if ((this.mUIItemWindow15 == null))
                {
                    this.mUIItemWindow15 = new UIItemWindow(this, "27");
                }
                return this.mUIItemWindow15;
            }
        }

        public UIItemWindow UIItemWindow16
        {
            get
            {
                if ((this.mUIItemWindow16 == null))
                {
                    this.mUIItemWindow16 = new UIItemWindow(this, "2", "2");
                }
                return this.mUIItemWindow16;
            }
        }

        public UIItemWindow UIItemWindow17
        {
            get
            {
                if ((this.mUIItemWindow17 == null))
                {
                    this.mUIItemWindow17 = new UIItemWindow(this, "25");
                }
                return this.mUIItemWindow17;
            }
        }

        public UIItemWindow UIBuildingCoverDetailsWindow
        {
            get
            {
                if ((this.mUIBuildingCoverDetailsWindow == null))
                {
                    this.mUIBuildingCoverDetailsWindow = new UIItemWindow(this, "24");
                }
                return this.mUIBuildingCoverDetailsWindow;
            }
        }

        public UIItemWindow UIItemWindow18
        {
            get
            {
                if ((this.mUIItemWindow18 == null))
                {
                    this.mUIItemWindow18 = new UIItemWindow(this, className: "ThunderRT6UserControlDC", instance: "6");
                }
                return this.mUIItemWindow18;
            }
        }

        public UIItemWindow UIItemWindow19
        {
            get
            {
                if ((this.mUIItemWindow19 == null))
                {
                    this.mUIItemWindow19 = new UIItemWindow(this, "2", "6");
                }
                return this.mUIItemWindow19;
            }
        }

        public UIItemWindow UIItemWindow20
        {
            get
            {
                if ((this.mUIItemWindow20 == null))
                {
                    this.mUIItemWindow20 = new UIItemWindow(this, "2", "4");
                }
                return this.mUIItemWindow20;
            }
        }

        public UIItemWindow UIItemWindow21
        {
            get
            {
                if ((this.mUIItemWindow21 == null))
                {
                    this.mUIItemWindow21 = new UIItemWindow(this, "30");
                }
                return this.mUIItemWindow21;
            }
        }

        public UIItemWindow UIItemWindow22
        {
            get
            {
                if ((this.mUIItemWindow22 == null))
                {
                    this.mUIItemWindow22 = new UIItemWindow(this, "2", "5");
                }
                return this.mUIItemWindow22;
            }
        }

        public UIItemWindow UIAnyindividualitemswoWindow
        {
            get
            {
                if ((this.mUIAnyindividualitemswoWindow == null))
                {
                    this.mUIAnyindividualitemswoWindow = new UIItemWindow(this, "32");
                }
                return this.mUIAnyindividualitemswoWindow;
            }
        }

        public UIItemWindow UIItemsWindow
        {
            get
            {
                if ((this.mUIItemsWindow == null))
                {
                    this.mUIItemsWindow = new UIItemWindow(this, "31");
                }
                return this.mUIItemsWindow;
            }
        }

        public UIItemWindow UIDoyourequirecoverforWindow
        {
            get
            {
                if ((this.mUIDoyourequirecoverforWindow == null))
                {
                    this.mUIDoyourequirecoverforWindow = new UIItemWindow(this, "35");
                }
                return this.mUIDoyourequirecoverforWindow;
            }
        }

        public UIItemWindow UIItemWindow23
        {
            get
            {
                if ((this.mUIItemWindow23 == null))
                {
                    this.mUIItemWindow23 = new UIItemWindow(this, "2", "7");
                }
                return this.mUIItemWindow23;
            }
        }

        public UIItemWindow UINextWindow4
        {
            get
            {
                if ((this.mUINextWindow4 == null))
                {
                    this.mUINextWindow4 = new UIItemWindow(this, "110");
                }
                return this.mUINextWindow4;
            }
        }

        public UIItemWindow UIItemWindow24
        {
            get
            {
                if ((this.mUIItemWindow24 == null))
                {
                    this.mUIItemWindow24 = new UIItemWindow(this, "2", "9");
                }
                return this.mUIItemWindow24;
            }
        }

        public UIItemWindow UIItemWindow25
        {
            get
            {
                if ((this.mUIItemWindow25 == null))
                {
                    this.mUIItemWindow25 = new UIItemWindow(this, "2", "8");
                }
                return this.mUIItemWindow25;
            }
        }

        public UIItemWindow UITotalAllRisksOutsideWindow
        {
            get
            {
                if ((this.mUITotalAllRisksOutsideWindow == null))
                {
                    this.mUITotalAllRisksOutsideWindow = new UIItemWindow(this, "44");
                }
                return this.mUITotalAllRisksOutsideWindow;
            }
        }

        public UIItemWindow UIDoyourequirecoverforWindow1
        {
            get
            {
                if ((this.mUIDoyourequirecoverforWindow1 == null))
                {
                    this.mUIDoyourequirecoverforWindow1 = new UIItemWindow(this, "43");
                }
                return this.mUIDoyourequirecoverforWindow1;
            }
        }

        public UIItemWindow UICyclesWindow
        {
            get
            {
                if ((this.mUICyclesWindow == null))
                {
                    this.mUICyclesWindow = new UIItemWindow(this, "42");
                }
                return this.mUICyclesWindow;
            }
        }

        public UIItemWindow UIDoyourequirecoverforWindow2
        {
            get
            {
                if ((this.mUIDoyourequirecoverforWindow2 == null))
                {
                    this.mUIDoyourequirecoverforWindow2 = new UIItemWindow(this, "39");
                }
                return this.mUIDoyourequirecoverforWindow2;
            }
        }

        public UIItemWindow UIItemWindow26
        {
            get
            {
                if ((this.mUIItemWindow26 == null))
                {
                    this.mUIItemWindow26 = new UIItemWindow(this, "2", "8");
                }
                return this.mUIItemWindow26;
            }
        }

        public UIItemWindow UIDoyourequirecoverforWindow3
        {
            get
            {
                if ((this.mUIDoyourequirecoverforWindow3 == null))
                {
                    this.mUIDoyourequirecoverforWindow3 = new UIItemWindow(this, "40");
                }
                return this.mUIDoyourequirecoverforWindow3;
            }
        }

        public UIItemWindow UIItemWindow27
        {
            get
            {
                if ((this.mUIItemWindow27 == null))
                {
                    this.mUIItemWindow27 = new UIItemWindow(this, "2", "8");
                }
                return this.mUIItemWindow27;
            }
        }

        public UIItemWindow UIDoyourequirecoverforWindow4
        {
            get
            {
                if ((this.mUIDoyourequirecoverforWindow4 == null))
                {
                    this.mUIDoyourequirecoverforWindow4 = new UIItemWindow(this, "37");
                }
                return this.mUIDoyourequirecoverforWindow4;
            }
        }

        public UIItemWindow UINextWindow5
        {
            get
            {
                if ((this.mUINextWindow5 == null))
                {
                    this.mUINextWindow5 = new UIItemWindow(this, "77");
                }
                return this.mUINextWindow5;
            }
        }

        public UIItemWindow UIGeneralWindow
        {
            get
            {
                if ((this.mUIGeneralWindow == null))
                {
                    this.mUIGeneralWindow = new UIItemWindow(this, "47");
                }
                return this.mUIGeneralWindow;
            }
        }

        public UIItemWindow UIIsthepropertyusedforWindow
        {
            get
            {
                if ((this.mUIIsthepropertyusedforWindow == null))
                {
                    this.mUIIsthepropertyusedforWindow = new UIItemWindow(this, "53");
                }
                return this.mUIIsthepropertyusedforWindow;
            }
        }

        public UIItemWindow UIIsthebusinessuseforcWindow
        {
            get
            {
                if ((this.mUIIsthebusinessuseforcWindow == null))
                {
                    this.mUIIsthebusinessuseforcWindow = new UIItemWindow(this, "50");
                }
                return this.mUIIsthebusinessuseforcWindow;
            }
        }

        public UIItemWindow UINextWindow6
        {
            get
            {
                if ((this.mUINextWindow6 == null))
                {
                    this.mUINextWindow6 = new UIItemWindow(this, "78");
                }
                return this.mUINextWindow6;
            }
        }

        public UIItemWindow UIHavespecialconditionWindow
        {
            get
            {
                if ((this.mUIHavespecialconditionWindow == null))
                {
                    this.mUIHavespecialconditionWindow = new UIItemWindow(this, "64");
                }
                return this.mUIHavespecialconditionWindow;
            }
        }

        public UIItemWindow UIQuoteWindow
        {
            get
            {
                if ((this.mUIQuoteWindow == null))
                {
                    this.mUIQuoteWindow = new UIItemWindow(this, "12");
                }
                return this.mUIQuoteWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIIstheapplicationinjoWindow;

        private UIItemWindow mUIOtherpersonWindow;

        private UIItemWindow mUIItemWindow2;

        private UIItemWindow mUIItemWindow3;

        private UIItemWindow mUIItemWindow4;

        private UIItemWindow mUINextWindow;

        private UIItemWindow mUIItemWindow5;

        private UIItemWindow mUIItemWindow6;

        private UIItemWindow mUIItemWindow7;

        private UIItemWindow mUIAreyouafirsttimebuyeWindow;

        private UIItemWindow mUIItemWindow8;

        private UIItemWindow mUIItemWindow9;

        private UIItemWindow mUIItemWindow10;

        private UIItemWindow mUIDoesanypartofthepropWindow;

        private UIItemWindow mUIItemWindow11;

        private UIItemWindow mUINextWindow1;

        private UIItemWindow mUIDoesthepropertyhaveaWindow;

        private UIItemWindow mUIArethereapprovedlockWindow;

        private UIItemWindow mUIArethereapprovedlockWindow1;

        private UIItemWindow mUIDoesthepropertyhaveaWindow1;

        private UIItemWindow mUIArethereapprovedlockWindow2;

        private UIItemWindow mUIDoesthepropertyhaveaWindow2;

        private UIItemWindow mUIArethereapprovedlockWindow3;

        private UIItemWindow mUIDoesthepropertyhaveaWindow3;

        private UIItemWindow mUIArethereapprovedlockWindow4;

        private UIItemWindow mUINextWindow2;

        private UIItemWindow mUIIncludedinaNeighbourWindow;

        private UIItemWindow mUIDoesthepropertyhavesWindow;

        private UIItemWindow mUIDoesthepropertyhaveaWindow4;

        private UIItemWindow mUIIsthereanalarmmainteWindow;

        private UIItemWindow mUIDoesthepropertyhaveaWindow5;

        private UIItemWindow mUIItemWindow12;

        private UIItemWindow mUIItemWindow13;

        private UIItemWindow mUINextWindow3;

        private UIItemWindow mUIItemWindow14;

        private UIItemWindow mUIItemWindow15;

        private UIItemWindow mUIItemWindow16;

        private UIItemWindow mUIItemWindow17;

        private UIItemWindow mUIBuildingCoverDetailsWindow;

        private UIItemWindow mUIItemWindow18;

        private UIItemWindow mUIItemWindow19;

        private UIItemWindow mUIItemWindow20;

        private UIItemWindow mUIItemWindow21;

        private UIItemWindow mUIItemWindow22;

        private UIItemWindow mUIAnyindividualitemswoWindow;

        private UIItemWindow mUIItemsWindow;

        private UIItemWindow mUIDoyourequirecoverforWindow;

        private UIItemWindow mUIItemWindow23;

        private UIItemWindow mUINextWindow4;

        private UIItemWindow mUIItemWindow24;

        private UIItemWindow mUIItemWindow25;

        private UIItemWindow mUITotalAllRisksOutsideWindow;

        private UIItemWindow mUIDoyourequirecoverforWindow1;

        private UIItemWindow mUICyclesWindow;

        private UIItemWindow mUIDoyourequirecoverforWindow2;

        private UIItemWindow mUIItemWindow26;

        private UIItemWindow mUIDoyourequirecoverforWindow3;

        private UIItemWindow mUIItemWindow27;

        private UIItemWindow mUIDoyourequirecoverforWindow4;

        private UIItemWindow mUINextWindow5;

        private UIItemWindow mUIGeneralWindow;

        private UIItemWindow mUIIsthepropertyusedforWindow;

        private UIItemWindow mUIIsthebusinessuseforcWindow;

        private UIItemWindow mUINextWindow6;

        private UIItemWindow mUIHavespecialconditionWindow;

        private UIItemWindow mUIQuoteWindow;

        #endregion
    }
}