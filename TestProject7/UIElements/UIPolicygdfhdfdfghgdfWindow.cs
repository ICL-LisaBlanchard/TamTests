namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPolicygdfhdfdfghgdfWindow : WinWindow
    {
        public UIPolicygdfhdfdfghgdfWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Policy: gdfhdf dfghgdf";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            this.WindowTitles.Add("Policy: gdfhdf dfghgdf");

            #endregion
        }

        #region Properties

        public UIBillingScreenHOMETESWindow UIBillingScreenHOMETESWindow
        {
            get
            {
                if ((this.mUIBillingScreenHOMETESWindow == null))
                {
                    this.mUIBillingScreenHOMETESWindow = new UIBillingScreenHOMETESWindow(this);
                }
                return this.mUIBillingScreenHOMETESWindow;
            }
        }

        #endregion

        #region Fields

        private UIBillingScreenHOMETESWindow mUIBillingScreenHOMETESWindow;

        #endregion
    }
}