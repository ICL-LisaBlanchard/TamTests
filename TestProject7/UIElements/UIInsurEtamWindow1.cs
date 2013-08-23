namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIInsurEtamWindow1 : WinWindow
    {
        public UIInsurEtamWindow1()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Personal Lines";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("insur-E.tam");

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

        public UIYesWindow1 UIYesWindow
        {
            get
            {
                if ((this.mUIYesWindow == null))
                {
                    this.mUIYesWindow = new UIYesWindow1(this);
                }
                return this.mUIYesWindow;
            }
        }

        public UIOKWindow12 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow12(this);
                }
                return this.mUIOKWindow;
            }
        }

        public UINOWindow1 UINOWindow
        {
            get
            {
                if ((this.mUINOWindow == null))
                {
                    this.mUINOWindow = new UINOWindow1(this);
                }
                return this.mUINOWindow;
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

                    this.mUIInsurEtamDialog.SearchProperties[UITestControl.PropertyNames.Name] = "insur-E.tam";
                    this.mUIInsurEtamDialog.SearchProperties[UITestControl.PropertyNames.ControlType] = "Dialog";
                    this.mUIInsurEtamDialog.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUIInsurEtamDialog;
            }
        }

        public UIOKWindow13 UIOKWindow1
        {
            get
            {
                if ((this.mUIOKWindow1 == null))
                {
                    this.mUIOKWindow1 = new UIOKWindow13(this);
                }
                return this.mUIOKWindow1;
            }
        }

        #endregion

        #region Fields

        private UIAcceptthisquoteNotOvWindow mUIAcceptthisquoteNotOvWindow;

        private UIYesWindow1 mUIYesWindow;

        private UIOKWindow12 mUIOKWindow;

        private UINOWindow1 mUINOWindow;

        private WinControl mUIInsurEtamDialog;

        private UIOKWindow13 mUIOKWindow1;

        #endregion
    }
}