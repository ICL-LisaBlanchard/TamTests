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
                    mUIItemWindow = new UIItemWindow(this, "86");
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
                    mUIItemWindow1 = new UIItemWindow(this, "85");
                }
                return mUIItemWindow1;
            }
        }

        public UIItemWindow UIIstheapplicationinjoWindow
        {
            get
            {
                if ((mUIIstheapplicationinjoWindow == null))
                {
                    mUIIstheapplicationinjoWindow = new UIItemWindow(this, "91");
                }
                return mUIIstheapplicationinjoWindow;
            }
        }

        public UIItemWindow UIOtherpersonWindow
        {
            get
            {
                if ((mUIOtherpersonWindow == null))
                {
                    mUIOtherpersonWindow = new UIItemWindow(this, "90");
                }
                return mUIOtherpersonWindow;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((mUIItemWindow2 == null))
                {
                    mUIItemWindow2 = new UIItemWindow(this, "106");
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
                    mUIItemWindow3 = new UIItemWindow(this, "2", "11");
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
                    mUIItemWindow4 = new UIItemWindow(this, "2", "12");
                }
                return mUIItemWindow4;
            }
        }

        public UIItemWindow UINextWindow
        {
            get
            {
                if ((mUINextWindow == null))
                {
                    mUINextWindow = new UIItemWindow(this, "82");
                }
                return mUINextWindow;
            }
        }

        public UIItemWindow UIItemWindow5
        {
            get
            {
                if ((mUIItemWindow5 == null))
                {
                    mUIItemWindow5 = new UIItemWindow(this, "2", "13");
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
                    mUIItemWindow6 = new UIItemWindow(this, "143");
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
                    mUIItemWindow7 = new UIItemWindow(this, "144");
                }
                return mUIItemWindow7;
            }
        }

        public UIItemWindow UIAreyouafirsttimebuyeWindow
        {
            get
            {
                if ((mUIAreyouafirsttimebuyeWindow == null))
                {
                    mUIAreyouafirsttimebuyeWindow = new UIItemWindow(this, "145");
                }
                return mUIAreyouafirsttimebuyeWindow;
            }
        }

        public UIItemWindow UIItemWindow8
        {
            get
            {
                if ((mUIItemWindow8 == null))
                {
                    mUIItemWindow8 = new UIItemWindow(this, "1", "4");
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
                    mUIItemWindow9 = new UIItemWindow(this, "152");
                }
                return mUIItemWindow9;
            }
        }

        public UIItemWindow UIItemWindow10
        {
            get
            {
                if ((mUIItemWindow10 == null))
                {
                    mUIItemWindow10 = new UIItemWindow(this, "151");
                }
                return mUIItemWindow10;
            }
        }

        public UIItemWindow UIDoesanypartofthepropWindow
        {
            get
            {
                if ((mUIDoesanypartofthepropWindow == null))
                {
                    mUIDoesanypartofthepropWindow = new UIItemWindow(this, "149");
                }
                return mUIDoesanypartofthepropWindow;
            }
        }

        public UIItemWindow UIItemWindow11
        {
            get
            {
                if ((mUIItemWindow11 == null))
                {
                    mUIItemWindow11 = new UIItemWindow(this, "2", "15");
                }
                return mUIItemWindow11;
            }
        }

        public UIItemWindow UINextWindow1
        {
            get
            {
                if ((mUINextWindow1 == null))
                {
                    mUINextWindow1 = new UIItemWindow(this, "136");
                }
                return mUINextWindow1;
            }
        }

        public UIItemWindow UIDoesthepropertyhaveaWindow
        {
            get
            {
                if ((mUIDoesthepropertyhaveaWindow == null))
                {
                    mUIDoesthepropertyhaveaWindow = new UIItemWindow(this, "127");
                }
                return mUIDoesthepropertyhaveaWindow;
            }
        }

        public UIItemWindow UIArethereapprovedlockWindow
        {
            get
            {
                if ((mUIArethereapprovedlockWindow == null))
                {
                    mUIArethereapprovedlockWindow = new UIItemWindow(this, "126");
                }
                return mUIArethereapprovedlockWindow;
            }
        }

        public UIItemWindow UIArethereapprovedlockWindow1
        {
            get
            {
                if ((mUIArethereapprovedlockWindow1 == null))
                {
                    mUIArethereapprovedlockWindow1 = new UIItemWindow(this, "125");
                }
                return mUIArethereapprovedlockWindow1;
            }
        }

        public UIItemWindow UIDoesthepropertyhaveaWindow1
        {
            get
            {
                if ((mUIDoesthepropertyhaveaWindow1 == null))
                {
                    mUIDoesthepropertyhaveaWindow1 = new UIItemWindow(this, "124");
                }
                return mUIDoesthepropertyhaveaWindow1;
            }
        }

        public UIItemWindow UIArethereapprovedlockWindow2
        {
            get
            {
                if ((mUIArethereapprovedlockWindow2 == null))
                {
                    mUIArethereapprovedlockWindow2 = new UIItemWindow(this, "123");
                }
                return mUIArethereapprovedlockWindow2;
            }
        }

        public UIItemWindow UIDoesthepropertyhaveaWindow2
        {
            get
            {
                if ((mUIDoesthepropertyhaveaWindow2 == null))
                {
                    mUIDoesthepropertyhaveaWindow2 = new UIItemWindow(this, "122");
                }
                return mUIDoesthepropertyhaveaWindow2;
            }
        }

        public UIItemWindow UIArethereapprovedlockWindow3
        {
            get
            {
                if ((mUIArethereapprovedlockWindow3 == null))
                {
                    mUIArethereapprovedlockWindow3 = new UIItemWindow(this, "121");
                }
                return mUIArethereapprovedlockWindow3;
            }
        }

        public UIItemWindow UIDoesthepropertyhaveaWindow3
        {
            get
            {
                if ((mUIDoesthepropertyhaveaWindow3 == null))
                {
                    mUIDoesthepropertyhaveaWindow3 = new UIItemWindow(this, "120");
                }
                return mUIDoesthepropertyhaveaWindow3;
            }
        }

        public UIItemWindow UIArethereapprovedlockWindow4
        {
            get
            {
                if ((mUIArethereapprovedlockWindow4 == null))
                {
                    mUIArethereapprovedlockWindow4 = new UIItemWindow(this, "119");
                }
                return mUIArethereapprovedlockWindow4;
            }
        }

        public UIItemWindow UINextWindow2
        {
            get
            {
                if ((mUINextWindow2 == null))
                {
                    mUINextWindow2 = new UIItemWindow(this, "135");
                }
                return mUINextWindow2;
            }
        }

        public UIItemWindow UIIncludedinaNeighbourWindow
        {
            get
            {
                if ((mUIIncludedinaNeighbourWindow == null))
                {
                    mUIIncludedinaNeighbourWindow = new UIItemWindow(this, "21");
                }
                return mUIIncludedinaNeighbourWindow;
            }
        }

        public UIItemWindow UIDoesthepropertyhavesWindow
        {
            get
            {
                if ((mUIDoesthepropertyhavesWindow == null))
                {
                    mUIDoesthepropertyhavesWindow = new UIItemWindow(this, "17");
                }
                return mUIDoesthepropertyhavesWindow;
            }
        }

        public UIItemWindow UIDoesthepropertyhaveaWindow4
        {
            get
            {
                if ((mUIDoesthepropertyhaveaWindow4 == null))
                {
                    mUIDoesthepropertyhaveaWindow4 = new UIItemWindow(this, "16");
                }
                return mUIDoesthepropertyhaveaWindow4;
            }
        }

        public UIItemWindow UIIsthereanalarmmainteWindow
        {
            get
            {
                if ((mUIIsthereanalarmmainteWindow == null))
                {
                    mUIIsthereanalarmmainteWindow = new UIItemWindow(this, "15");
                }
                return mUIIsthereanalarmmainteWindow;
            }
        }

        public UIItemWindow UIDoesthepropertyhaveaWindow5
        {
            get
            {
                if ((mUIDoesthepropertyhaveaWindow5 == null))
                {
                    mUIDoesthepropertyhaveaWindow5 = new UIItemWindow(this, "14");
                }
                return mUIDoesthepropertyhaveaWindow5;
            }
        }

        public UIItemWindow UIItemWindow12
        {
            get
            {
                if ((mUIItemWindow12 == null))
                {
                    mUIItemWindow12 = new UIItemWindow(this, "22");
                }
                return mUIItemWindow12;
            }
        }

        public UIItemWindow UIItemWindow13
        {
            get
            {
                if ((mUIItemWindow13 == null))
                {
                    mUIItemWindow13 = new UIItemWindow(this, "23");
                }
                return mUIItemWindow13;
            }
        }

        public UIItemWindow UINextWindow3
        {
            get
            {
                if ((mUINextWindow3 == null))
                {
                    mUINextWindow3 = new UIItemWindow(this, "117");
                }
                return mUINextWindow3;
            }
        }

        public UIItemWindow UIItemWindow14
        {
            get
            {
                if ((mUIItemWindow14 == null))
                {
                    mUIItemWindow14 = new UIItemWindow(this, "2", "3");
                }
                return mUIItemWindow14;
            }
        }

        public UIItemWindow UIItemWindow15
        {
            get
            {
                if ((mUIItemWindow15 == null))
                {
                    mUIItemWindow15 = new UIItemWindow(this, "27");
                }
                return mUIItemWindow15;
            }
        }

        public UIItemWindow UIItemWindow16
        {
            get
            {
                if ((mUIItemWindow16 == null))
                {
                    mUIItemWindow16 = new UIItemWindow(this, "2", "2");
                }
                return mUIItemWindow16;
            }
        }

        public UIItemWindow UIItemWindow17
        {
            get
            {
                if ((mUIItemWindow17 == null))
                {
                    mUIItemWindow17 = new UIItemWindow(this, "25");
                }
                return mUIItemWindow17;
            }
        }

        public UIItemWindow UIBuildingCoverDetailsWindow
        {
            get
            {
                if ((mUIBuildingCoverDetailsWindow == null))
                {
                    mUIBuildingCoverDetailsWindow = new UIItemWindow(this, "24");
                }
                return mUIBuildingCoverDetailsWindow;
            }
        }

        public UIItemWindow UIItemWindow18
        {
            get
            {
                if ((mUIItemWindow18 == null))
                {
                    mUIItemWindow18 = new UIItemWindow(this, className: "ThunderRT6UserControlDC", instance: "6");
                }
                return mUIItemWindow18;
            }
        }

        public UIItemWindow UIItemWindow19
        {
            get
            {
                if ((mUIItemWindow19 == null))
                {
                    mUIItemWindow19 = new UIItemWindow(this, "2", "6");
                }
                return mUIItemWindow19;
            }
        }

        public UIItemWindow UIItemWindow20
        {
            get
            {
                if ((mUIItemWindow20 == null))
                {
                    mUIItemWindow20 = new UIItemWindow(this, "2", "4");
                }
                return mUIItemWindow20;
            }
        }

        public UIItemWindow UIItemWindow21
        {
            get
            {
                if ((mUIItemWindow21 == null))
                {
                    mUIItemWindow21 = new UIItemWindow(this, "30");
                }
                return mUIItemWindow21;
            }
        }

        public UIItemWindow UIItemWindow22
        {
            get
            {
                if ((mUIItemWindow22 == null))
                {
                    mUIItemWindow22 = new UIItemWindow(this, "2", "5");
                }
                return mUIItemWindow22;
            }
        }

        public UIItemWindow UIAnyindividualitemswoWindow
        {
            get
            {
                if ((mUIAnyindividualitemswoWindow == null))
                {
                    mUIAnyindividualitemswoWindow = new UIItemWindow(this, "32");
                }
                return mUIAnyindividualitemswoWindow;
            }
        }

        public UIItemWindow UIItemsWindow
        {
            get
            {
                if ((mUIItemsWindow == null))
                {
                    mUIItemsWindow = new UIItemWindow(this, "31");
                }
                return mUIItemsWindow;
            }
        }

        public UIItemWindow UIDoyourequirecoverforWindow
        {
            get
            {
                if ((mUIDoyourequirecoverforWindow == null))
                {
                    mUIDoyourequirecoverforWindow = new UIItemWindow(this, "35");
                }
                return mUIDoyourequirecoverforWindow;
            }
        }

        public UIItemWindow UIItemWindow23
        {
            get
            {
                if ((mUIItemWindow23 == null))
                {
                    mUIItemWindow23 = new UIItemWindow(this, "2", "7");
                }
                return mUIItemWindow23;
            }
        }

        public UIItemWindow UINextWindow4
        {
            get
            {
                if ((mUINextWindow4 == null))
                {
                    mUINextWindow4 = new UIItemWindow(this, "110");
                }
                return mUINextWindow4;
            }
        }

        public UIItemWindow UIItemWindow24
        {
            get
            {
                if ((mUIItemWindow24 == null))
                {
                    mUIItemWindow24 = new UIItemWindow(this, "2", "9");
                }
                return mUIItemWindow24;
            }
        }

        public UIItemWindow UIItemWindow25
        {
            get
            {
                if ((mUIItemWindow25 == null))
                {
                    mUIItemWindow25 = new UIItemWindow(this, "2", "8");
                }
                return mUIItemWindow25;
            }
        }

        public UIItemWindow UITotalAllRisksOutsideWindow
        {
            get
            {
                if ((mUITotalAllRisksOutsideWindow == null))
                {
                    mUITotalAllRisksOutsideWindow = new UIItemWindow(this, "44");
                }
                return mUITotalAllRisksOutsideWindow;
            }
        }

        public UIItemWindow UIDoyourequirecoverforWindow1
        {
            get
            {
                if ((mUIDoyourequirecoverforWindow1 == null))
                {
                    mUIDoyourequirecoverforWindow1 = new UIItemWindow(this, "43");
                }
                return mUIDoyourequirecoverforWindow1;
            }
        }

        public UIItemWindow UICyclesWindow
        {
            get
            {
                if ((mUICyclesWindow == null))
                {
                    mUICyclesWindow = new UIItemWindow(this, "42");
                }
                return mUICyclesWindow;
            }
        }

        public UIItemWindow UIDoyourequirecoverforWindow2
        {
            get
            {
                if ((mUIDoyourequirecoverforWindow2 == null))
                {
                    mUIDoyourequirecoverforWindow2 = new UIItemWindow(this, "39");
                }
                return mUIDoyourequirecoverforWindow2;
            }
        }

        public UIItemWindow UIItemWindow26
        {
            get
            {
                if ((mUIItemWindow26 == null))
                {
                    mUIItemWindow26 = new UIItemWindow(this, "2", "8");
                }
                return mUIItemWindow26;
            }
        }

        public UIItemWindow UIDoyourequirecoverforWindow3
        {
            get
            {
                if ((mUIDoyourequirecoverforWindow3 == null))
                {
                    mUIDoyourequirecoverforWindow3 = new UIItemWindow(this, "40");
                }
                return mUIDoyourequirecoverforWindow3;
            }
        }

        public UIItemWindow UIItemWindow27
        {
            get
            {
                if ((mUIItemWindow27 == null))
                {
                    mUIItemWindow27 = new UIItemWindow(this, "2", "8");
                }
                return mUIItemWindow27;
            }
        }

        public UIItemWindow UIDoyourequirecoverforWindow4
        {
            get
            {
                if ((mUIDoyourequirecoverforWindow4 == null))
                {
                    mUIDoyourequirecoverforWindow4 = new UIItemWindow(this, "37");
                }
                return mUIDoyourequirecoverforWindow4;
            }
        }

        public UIItemWindow UINextWindow5
        {
            get
            {
                if ((mUINextWindow5 == null))
                {
                    mUINextWindow5 = new UIItemWindow(this, "77");
                }
                return mUINextWindow5;
            }
        }

        public UIItemWindow UIGeneralWindow
        {
            get
            {
                if ((mUIGeneralWindow == null))
                {
                    mUIGeneralWindow = new UIItemWindow(this, "47");
                }
                return mUIGeneralWindow;
            }
        }

        public UIItemWindow UIIsthepropertyusedforWindow
        {
            get
            {
                if ((mUIIsthepropertyusedforWindow == null))
                {
                    mUIIsthepropertyusedforWindow = new UIItemWindow(this, "53");
                }
                return mUIIsthepropertyusedforWindow;
            }
        }

        public UIItemWindow UIIsthebusinessuseforcWindow
        {
            get
            {
                if ((mUIIsthebusinessuseforcWindow == null))
                {
                    mUIIsthebusinessuseforcWindow = new UIItemWindow(this, "50");
                }
                return mUIIsthebusinessuseforcWindow;
            }
        }

        public UIItemWindow UINextWindow6
        {
            get
            {
                if ((mUINextWindow6 == null))
                {
                    mUINextWindow6 = new UIItemWindow(this, "78");
                }
                return mUINextWindow6;
            }
        }

        public UIItemWindow UIHavespecialconditionWindow
        {
            get
            {
                if ((mUIHavespecialconditionWindow == null))
                {
                    mUIHavespecialconditionWindow = new UIItemWindow(this, "64");
                }
                return mUIHavespecialconditionWindow;
            }
        }

        public UIItemWindow UIQuoteWindow
        {
            get
            {
                if ((mUIQuoteWindow == null))
                {
                    mUIQuoteWindow = new UIItemWindow(this, "12");
                }
                return mUIQuoteWindow;
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