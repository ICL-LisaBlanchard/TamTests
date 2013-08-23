namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPolicyrtyertWindow : WinWindow
    {
        public UIPolicyrtyertWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Policy: rty ert";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            this.WindowTitles.Add("Policy: rty ert");

            #endregion
        }

        #region Properties

        public UIBillingScreenMOTOTESWindow UIBillingScreenMOTOTESWindow
        {
            get
            {
                if ((this.mUIBillingScreenMOTOTESWindow == null))
                {
                    this.mUIBillingScreenMOTOTESWindow = new UIBillingScreenMOTOTESWindow(this);
                }
                return this.mUIBillingScreenMOTOTESWindow;
            }
        }

        #endregion

        #region Fields

        private UIBillingScreenMOTOTESWindow mUIBillingScreenMOTOTESWindow;

        #endregion
    }
}