namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIAUTO2311001Window : WinWindow
    {
        public UIAUTO2311001Window()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "AUTO231-1001";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("AUTO231-1001");

            #endregion
        }

        #region Properties

        public UIItemWindow UIRenewPolicyWindow
        {
            get
            {
                if ((mUIRenewPolicyWindow == null))
                {
                    mUIRenewPolicyWindow = new UIItemWindow(this, "25");
                }
                return mUIRenewPolicyWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIRenewPolicyWindow;

        #endregion
    }
}