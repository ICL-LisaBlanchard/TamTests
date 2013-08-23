namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

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

        public UIItemWindow38 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow38(this);
                }
                return this.mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private WinClient mUIDemandsNeedsMotorComClient;

        private UIItemWindow38 mUIItemWindow;

        #endregion
    }
}