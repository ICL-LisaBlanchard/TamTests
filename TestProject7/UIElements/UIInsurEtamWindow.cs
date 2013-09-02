namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIInsurEtamWindow : WinWindow
    {
        public UIInsurEtamWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Personal Lines";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";

            #endregion
        }

        #region Properties

        public UIMotorQuotesWindow UIMotorQuotesWindow
        {
            get
            {
                if ((this.mUIMotorQuotesWindow == null))
                {
                    this.mUIMotorQuotesWindow = new UIMotorQuotesWindow(this);
                }
                return this.mUIMotorQuotesWindow;
            }
        }

        #endregion

        #region Fields

        private UIMotorQuotesWindow mUIMotorQuotesWindow;

        #endregion
    }
}