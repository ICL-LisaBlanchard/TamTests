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

            SearchProperties[UITestControl.PropertyNames.Name] = "Transaction List";
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            WindowTitles.Add("Transaction List");

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
                if ((mUILvwVListWindow == null))
                {
                    mUILvwVListWindow = new UIItemWindow(this, controlName: "lvwVList");
                }
                return mUILvwVListWindow;
            }
        }

        public UIItemList UILvwVListList
        {
            get
            {
                if ((mUILvwVListList == null))
                {
                    mUILvwVListList = new UIItemList(this, "Enter Code");
                }
                return mUILvwVListList;
            }
        }

        public UIItemWindow UICloseWindow
        {
            get
            {
                if ((mUICloseWindow == null))
                {
                    mUICloseWindow = new UIItemWindow(this, controlName: "btnExit");
                }
                return mUICloseWindow;
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