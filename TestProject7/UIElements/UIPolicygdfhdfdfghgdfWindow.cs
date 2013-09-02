namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPolicygdfhdfdfghgdfWindow : WinWindow
    {
        public UIPolicygdfhdfdfghgdfWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Policy: gdfhdf dfghgdf";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            this.WindowTitles.Add("Policy: gdfhdf dfghgdf");

            #endregion
        }

        #region Properties

        public UIBillingScreenHomeTestWindow UIBillingScreenHomeTestWindow
        {
            get
            {
                if ((this.mUIBillingScreenHomeTestWindow == null))
                {
                    this.mUIBillingScreenHomeTestWindow = new UIBillingScreenHomeTestWindow(this);
                }
                return this.mUIBillingScreenHomeTestWindow;
            }
        }

        #endregion

        #region Fields

        private UIBillingScreenHomeTestWindow mUIBillingScreenHomeTestWindow;

        #endregion
    }
}