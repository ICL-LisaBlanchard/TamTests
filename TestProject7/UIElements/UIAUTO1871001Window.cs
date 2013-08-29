﻿namespace AppliedSystems.Tam.Ui.Tests.UIElements
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
            this.windowTitle = "AUTO187-1001";
            this.WindowTitles.Add(this.windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIInviteWindow
        {
            get
            {
                if ((this.mUIInviteWindow == null))
                {
                    this.mUIInviteWindow = new UIItemWindow(this, name: "&Invite");
                }
                return this.mUIInviteWindow;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "17");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIRenewPolicyWindow
        {
            get
            {
                if ((this.mUIRenewPolicyWindow == null))
                {
                    this.mUIRenewPolicyWindow = new UIItemWindow(this, controlId: "10");
                }
                return this.mUIRenewPolicyWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIInviteWindow;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIRenewPolicyWindow;

        #endregion
    }
}