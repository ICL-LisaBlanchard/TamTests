namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

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

        public UIItemWindow UIExitWindow
        {
            get
            {
                if ((this.mUIExitWindow == null))
                {
                    this.mUIExitWindow = new UIItemWindow(this, "2");
                }
                return this.mUIExitWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIExitWindow;

        #endregion
    }
}