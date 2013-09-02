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

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Personal Lines";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add(this.windowTitle);

            #endregion
        }

        #region Properties

        public UIAcceptthisquoteNotOvWindow UIAcceptthisquoteNotOvWindow
        {
            get
            {
                if ((this.mUIAcceptthisquoteNotOvWindow == null))
                {
                    this.mUIAcceptthisquoteNotOvWindow = new UIAcceptthisquoteNotOvWindow(this);
                }
                return this.mUIAcceptthisquoteNotOvWindow;
            }
        }

        public UIItemWindow UIYesWindow
        {
            get
            {
                if ((this.mUIYesWindow == null))
                {
                    this.mUIYesWindow = new UIItemWindow(this, controlId: "6");
                }
                return this.mUIYesWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "2");
                }
                return this.mUIOKWindow;
            }
        }

        public UIItemWindow UINoWindow
        {
            get
            {
                if ((this.mUINoWindow == null))
                {
                    this.mUINoWindow = new UIItemWindow(this, controlId: "7");
                }
                return this.mUINoWindow;
            }
        }

        public UIItemWindow UIOKWindow1
        {
            get
            {
                if ((this.mUIOKWindow1 == null))
                {
                    this.mUIOKWindow1 = new UIItemWindow(this, controlId: "1");
                }
                return this.mUIOKWindow1;
            }
        }

        public WinControl UIInsurEtamDialog
        {
            get
            {
                if ((this.mUIInsurEtamDialog == null))
                {
                    this.mUIInsurEtamDialog = new WinControl(this);

                    #region Search Criteria

                    this.mUIInsurEtamDialog.SearchProperties[UITestControl.PropertyNames.Name] = this.windowTitle;
                    this.mUIInsurEtamDialog.SearchProperties[UITestControl.PropertyNames.ControlType] = "Dialog";
                    this.mUIInsurEtamDialog.WindowTitles.Add(this.windowTitle);

                    #endregion
                }
                return this.mUIInsurEtamDialog;
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