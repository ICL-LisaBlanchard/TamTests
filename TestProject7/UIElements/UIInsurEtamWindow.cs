namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIInsurEtamWindow : WinWindow
    {
        public UIInsurEtamWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Personal Lines";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            WindowTitles.Add("Personal Lines");

            #endregion
        }

        #region Properties

        public UIQuotesWindow UIQuotesWindow
        {
            get
            {
                if ((mUIQuotesWindow == null))
                {
                    mUIQuotesWindow = new UIQuotesWindow(this);
                }
                return mUIQuotesWindow;
            }
        }

        #endregion

        #region Fields

        private UIQuotesWindow mUIQuotesWindow;

        #endregion
    }
}