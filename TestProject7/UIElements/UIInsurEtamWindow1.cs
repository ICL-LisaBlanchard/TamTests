namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIInsurEtamWindow1 : WinWindow
    {
        public UIInsurEtamWindow1()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Personal Lines";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            WindowTitles.Add(windowTitle);

            #endregion
        }

        #region Properties

        public UIAcceptthisquoteNotOvWindow UIAcceptthisquoteNotOvWindow
        {
            get
            {
                if ((mUIAcceptthisquoteNotOvWindow == null))
                {
                    mUIAcceptthisquoteNotOvWindow = new UIAcceptthisquoteNotOvWindow(this);
                }
                return mUIAcceptthisquoteNotOvWindow;
            }
        }

        public UIItemWindow UIYesWindow
        {
            get
            {
                if ((mUIYesWindow == null))
                {
                    mUIYesWindow = new UIItemWindow(this, controlId: "6");
                }
                return mUIYesWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "2");
                }
                return mUIOKWindow;
            }
        }

        public UIItemWindow UINoWindow
        {
            get
            {
                if ((mUINoWindow == null))
                {
                    mUINoWindow = new UIItemWindow(this, controlId: "7");
                }
                return mUINoWindow;
            }
        }

        public UIItemWindow UIOKWindow1
        {
            get
            {
                if ((mUIOKWindow1 == null))
                {
                    mUIOKWindow1 = new UIItemWindow(this, controlId: "1");
                }
                return mUIOKWindow1;
            }
        }

        public WinControl UIInsurEtamDialog
        {
            get
            {
                if ((mUIInsurEtamDialog == null))
                {
                    mUIInsurEtamDialog = new WinControl(this);

                    #region Search Criteria

                    mUIInsurEtamDialog.SearchProperties[UITestControl.PropertyNames.Name] = windowTitle;
                    mUIInsurEtamDialog.SearchProperties[UITestControl.PropertyNames.ControlType] = "Dialog";
                    mUIInsurEtamDialog.WindowTitles.Add(windowTitle);

                    #endregion
                }
                return mUIInsurEtamDialog;
            }
        }

        #endregion

        #region Fields

        private UIAcceptthisquoteNotOvWindow mUIAcceptthisquoteNotOvWindow;

        private UIItemWindow mUIYesWindow;

        private UIItemWindow mUIOKWindow;

        private UIItemWindow mUINoWindow;

        private WinControl mUIInsurEtamDialog;

        private UIItemWindow mUIOKWindow1;

        private string windowTitle = "insur-E.tam";

        #endregion
    }
}