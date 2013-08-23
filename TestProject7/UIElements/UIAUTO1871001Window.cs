namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAUTO1871001Window : WinWindow
    {
        public UIAUTO1871001Window()
        {
            #region Search Criteria

            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "AUTO", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("AUTO187-1001");

            #endregion
        }

        #region Properties

        public UIInviteWindow UIInviteWindow
        {
            get
            {
                if ((this.mUIInviteWindow == null))
                {
                    this.mUIInviteWindow = new UIInviteWindow(this);
                }
                return this.mUIInviteWindow;
            }
        }

        public UIItemWindow66 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow66(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIRenewPolicyWindow UIRenewPolicyWindow
        {
            get
            {
                if ((this.mUIRenewPolicyWindow == null))
                {
                    this.mUIRenewPolicyWindow = new UIRenewPolicyWindow(this);
                }
                return this.mUIRenewPolicyWindow;
            }
        }

        #endregion

        #region Fields

        private UIInviteWindow mUIInviteWindow;

        private UIItemWindow66 mUIItemWindow;

        private UIRenewPolicyWindow mUIRenewPolicyWindow;

        #endregion
    }
}