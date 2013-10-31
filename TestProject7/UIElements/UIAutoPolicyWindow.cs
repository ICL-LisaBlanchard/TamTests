namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIAutoPolicyWindow : WinWindow
    {
        public UIAutoPolicyWindow()
        {
            #region Search Criteria

            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "-1001", PropertyExpressionOperator.Contains));
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            //windowTitle = "AUTO187-1001";
            //WindowTitles.Add(windowTitle);

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