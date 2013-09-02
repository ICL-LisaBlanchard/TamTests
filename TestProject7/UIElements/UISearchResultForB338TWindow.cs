namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UISearchResultForB338TWindow : WinWindow
    {
        public UISearchResultForB338TWindow()
        {
            #region Search Criteria

            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Search Result For", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";

            #endregion
        }

        #region Properties

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, "3");
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}