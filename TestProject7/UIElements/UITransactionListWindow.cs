namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITransactionListWindow : WinWindow
    {
        public UITransactionListWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Transaction List";
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Transaction List");

            #endregion
        }

        #region Properties

        public UILblBalanceWindow UILblBalanceWindow
        {
            get
            {
                if ((this.mUILblBalanceWindow == null))
                {
                    this.mUILblBalanceWindow = new UILblBalanceWindow(this);
                }
                return this.mUILblBalanceWindow;
            }
        }

        public UILvwVListWindow UILvwVListWindow
        {
            get
            {
                if ((this.mUILvwVListWindow == null))
                {
                    this.mUILvwVListWindow = new UILvwVListWindow(this);
                }
                return this.mUILvwVListWindow;
            }
        }

        public UICloseWindow1 UICloseWindow
        {
            get
            {
                if ((this.mUICloseWindow == null))
                {
                    this.mUICloseWindow = new UICloseWindow1(this);
                }
                return this.mUICloseWindow;
            }
        }

        #endregion

        #region Fields

        private UILblBalanceWindow mUILblBalanceWindow;

        private UILvwVListWindow mUILvwVListWindow;

        private UICloseWindow1 mUICloseWindow;

        #endregion
    }
}