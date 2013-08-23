namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPoliciesAutoRenewedAWindow : WinWindow
    {
        public UIPoliciesAutoRenewedAWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Policies Auto-Renewed & Auto-Lapsed";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Policies Auto-Renewed & Auto-Lapsed");

            #endregion
        }

        #region Properties

        public UIExitWindow5 UIExitWindow
        {
            get
            {
                if ((this.mUIExitWindow == null))
                {
                    this.mUIExitWindow = new UIExitWindow5(this);
                }
                return this.mUIExitWindow;
            }
        }

        #endregion

        #region Fields

        private UIExitWindow5 mUIExitWindow;

        #endregion
    }
}