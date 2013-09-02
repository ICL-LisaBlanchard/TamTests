namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

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
                return new UIClient(this, "Demands&Needs(");
            }
        }

        public UITestControl UIItemWindow
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

        private UITestControl mUIItemWindow;

        #endregion
    }
}