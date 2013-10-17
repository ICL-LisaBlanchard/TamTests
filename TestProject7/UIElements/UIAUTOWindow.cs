namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UiAutoWindow : WinWindow
    {
        public UiAutoWindow()
        {
            #region Search Criteria

            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "AUTO", PropertyExpressionOperator.Contains));
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "-1001", PropertyExpressionOperator.Contains));
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("AUTO230-1001");

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