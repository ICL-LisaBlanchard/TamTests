namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UITransactionListWindow1 : UIItemWindow
    {
        public UITransactionListWindow1()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Transaction List";
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Transaction List");

            #endregion
        }

        #region Properties

        public WinTitleBar UITransactionListTitleBar
        {
            get
            {
                return new UITitleBar(this);
            }
        }

        public UIItemWindow UILvwVListWindow
        {
            get
            {
                if ((this.mUILvwVListWindow == null))
                {
                    this.mUILvwVListWindow = new UIItemWindow(this, controlName: "lvwVList");
                }
                return this.mUILvwVListWindow;
            }
        }

        public UIItemList UILvwVListList
        {
            get
            {
                if ((this.mUILvwVListList == null))
                {
                    this.mUILvwVListList = new UIItemList(this, "Enter Code");
                }
                return this.mUILvwVListList;
            }
        }

        public UIItemWindow UICloseWindow
        {
            get
            {
                if ((this.mUICloseWindow == null))
                {
                    this.mUICloseWindow = new UIItemWindow(this, controlName: "btnExit");
                }
                return this.mUICloseWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUILvwVListWindow;

        private UIItemList mUILvwVListList;

        private UIItemWindow mUICloseWindow;

        #endregion
    }
}