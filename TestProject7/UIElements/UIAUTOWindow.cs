namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UiAutoWindow : WinWindow
    {
        public UiAutoWindow(string customerCode)
        {
            #region Search Criteria

            var windowTitle = customerCode + "-1001";
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, windowTitle, PropertyExpressionOperator.Contains));
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIRebrokeWindow
        {
            get
            {
                if ((mUIRebrokeWindow == null))
                {
                    mUIRebrokeWindow = new UIItemWindow(this, "30");
                }
                return mUIRebrokeWindow;
            }
        }

        public UIItemWindow UILapsePolicyWindow
        {
            get
            {
                if ((mUILapsePolicyWindow == null))
                {
                    mUILapsePolicyWindow = new UIItemWindow(this, "26");
                }
                return mUILapsePolicyWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIRebrokeWindow;

        private UIItemWindow mUILapsePolicyWindow;

        #endregion
    }
}