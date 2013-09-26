namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIAUTO2211001Window : WinWindow
    {
        public UIAUTO2211001Window()
        {
            #region Search Criteria

            windowTitle = "AUTO221-1001";
            SearchProperties[UITestControl.PropertyNames.Name] = windowTitle;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIRenewPolicyWindow
        {
            get
            {
                if ((mUIRenewPolicyWindow == null))
                {
                    mUIRenewPolicyWindow = new UIItemWindow(this, controlId: "10");
                }
                return mUIRenewPolicyWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIRenewPolicyWindow;

        #endregion
    }
}