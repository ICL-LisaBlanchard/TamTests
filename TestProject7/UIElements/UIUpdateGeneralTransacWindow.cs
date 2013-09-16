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

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Update General Transactions";
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Update General Transactions");

            #endregion
        }

        #region Properties

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UIItemWindow(this, controlName: "btnCancel");
                }
                return this.mUICancelWindow;
            }
        }

        public UIItemWindow UILblTranWindow
        {
            get
            {
                if ((this.mUILblTranWindow == null))
                {
                    this.mUILblTranWindow = new UIItemWindow(this, controlName: "lblTran");
                }
                return this.mUILblTranWindow;
            }
        }

        public UIItemWindow UILblBalanceWindow
        {
            get
            {
                if ((this.mUILblBalanceWindow == null))
                {
                    this.mUILblBalanceWindow = new UIItemWindow(this, controlName: "lblBalance");
                }
                return this.mUILblBalanceWindow;
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