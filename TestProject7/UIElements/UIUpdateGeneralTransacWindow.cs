namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIUpdateGeneralTransacWindow : WinWindow
    {
        public UIUpdateGeneralTransacWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Update General Transactions";
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            WindowTitles.Add("Update General Transactions");

            #endregion
        }

        #region Properties

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((mUICancelWindow == null))
                {
                    mUICancelWindow = new UIItemWindow(this, controlName: "btnCancel");
                }
                return mUICancelWindow;
            }
        }

        public UIItemWindow UILblTranWindow
        {
            get
            {
                if ((mUILblTranWindow == null))
                {
                    mUILblTranWindow = new UIItemWindow(this, controlName: "lblTran");
                }
                return mUILblTranWindow;
            }
        }

        public UIItemWindow UILblBalanceWindow
        {
            get
            {
                if ((mUILblBalanceWindow == null))
                {
                    mUILblBalanceWindow = new UIItemWindow(this, controlName: "lblBalance");
                }
                return mUILblBalanceWindow;
            }
        }

        public UITitleBar UITitleBar
        {
            get
            {
                return new UITitleBar(this);
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUICancelWindow;

        private UIItemWindow mUILblTranWindow;

        private UIItemWindow mUILblBalanceWindow;

        #endregion
    }
}