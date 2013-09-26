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

            SearchProperties[UITestControl.PropertyNames.Name] = "Policies Auto-Renewed & Auto-Lapsed";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("Policies Auto-Renewed & Auto-Lapsed");

            #endregion
        }

        #region Properties

        public UIItemWindow UIExitWindow
        {
            get
            {
                if ((mUIExitWindow == null))
                {
                    mUIExitWindow = new UIItemWindow(this, "2");
                }
                return mUIExitWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIExitWindow;

        #endregion
    }
}