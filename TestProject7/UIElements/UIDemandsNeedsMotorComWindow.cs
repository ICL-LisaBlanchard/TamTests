namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDemandsNeedsMotorComWindow : WinWindow
    {
        public UIDemandsNeedsMotorComWindow()
        {
            #region Search Criteria

            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Demands&Needs(", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "OpusApp";

            #endregion
        }

        #region Properties

        public WinClient UIDemandsNeedsMotorComClient
        {
            get
            {
                if ((this.mUIDemandsNeedsMotorComClient == null))
                {
                    this.mUIDemandsNeedsMotorComClient = new WinClient(this);

                    #region Search Criteria

                    this.mUIDemandsNeedsMotorComClient.SearchProperties.Add(
                        new PropertyExpression(UITestControl.PropertyNames.Name, "Demands&Needs(", PropertyExpressionOperator.Contains));

                    #endregion
                }
                return this.mUIDemandsNeedsMotorComClient;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, className: "NetUIHWND", accessible: "Ribbon");
                }
                return this.mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName = "Demands&Needs(Motor) [Compatibility Mode] - Microsoft Word";

        private WinClient mUIDemandsNeedsMotorComClient;

        private UIItemWindow mUIItemWindow;

        #endregion
    }
}