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
            this.WindowTitles.Add("Personal Lines");

            #endregion
        }

        #region Properties

        public UIQuotesWindow UIQuotesWindow
        {
            get
            {
                if ((this.mUIQuotesWindow == null))
                {
                    this.mUIQuotesWindow = new UIQuotesWindow(this);
                }
                return this.mUIQuotesWindow;
            }
        }

        #endregion

        #region Fields

        private UIQuotesWindow mUIQuotesWindow;

        #endregion
    }
}