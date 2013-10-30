namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIRenewalsNewBusinessAWindow : WinWindow
    {
        public UIRenewalsNewBusinessAWindow()
        {
            #region Search Criteria

            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "New Business Accept", PropertyExpressionOperator.Contains));
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Renewals", PropertyExpressionOperator.Contains));
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";

            #endregion
        }

        #region Properties

        public UIItemWindow UIPolicyListWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, className: "ListView20WndClass");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, instance: "2", className: "ListView20WndClass");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIAcceptWindow
        {
            get
            {
                if ((mUIAcceptWindow == null))
                {
                    mUIAcceptWindow = new UIItemWindow(this, controlId: "6");
                }
                return mUIAcceptWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIAcceptWindow;

        #endregion
    }
}