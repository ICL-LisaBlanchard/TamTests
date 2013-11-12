namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIAutoPolicyWindow : WinWindow
    {
        public UIAutoPolicyWindow(string customerCode)
        {
            #region Search Criteria

            var windowName = customerCode + "-1001";
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, windowName, PropertyExpressionOperator.Contains));
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIInviteWindow
        {
            get
            {
                if ((mUIInviteWindow == null))
                {
                    mUIInviteWindow = new UIItemWindow(this, name: "&Invite");
                }
                return mUIInviteWindow;
            }
        }

        public UITestControl UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "17");
                }
                return mUIItemWindow;
            }
        }

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

        private UIItemWindow mUIInviteWindow;

        private UITestControl mUIItemWindow;

        private UIItemWindow mUIRenewPolicyWindow;

        #endregion
    }
}