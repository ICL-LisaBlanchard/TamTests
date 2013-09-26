namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPolicygdfhdfdfghgdfWindow : WinWindow
    {
        public UIPolicygdfhdfdfghgdfWindow()
        {
            #region Search Criteria

            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Policy: ", PropertyExpressionOperator.Contains));
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            WindowTitles.Add("Policy: ");

            #endregion
        }

        #region Properties

        public UIBillingScreenHomeTestWindow UIBillingScreenHomeTestWindow
        {
            get
            {
                if ((mUIBillingScreenHomeTestWindow == null))
                {
                    mUIBillingScreenHomeTestWindow = new UIBillingScreenHomeTestWindow(this);
                }
                return mUIBillingScreenHomeTestWindow;
            }
        }

        #endregion

        #region Fields

        private UIBillingScreenHomeTestWindow mUIBillingScreenHomeTestWindow;

        #endregion
    }
}