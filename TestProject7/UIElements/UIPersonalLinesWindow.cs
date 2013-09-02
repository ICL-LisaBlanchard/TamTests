namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPersonalLinesWindow : WinWindow
    {
        public UIPersonalLinesWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Personal Lines";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            this.WindowTitles.Add("Personal Lines");

            #endregion
        }

        #region Properties

        public UIHouseholdQuoteWindow UIHouseholdQuoteWindow
        {
            get
            {
                if ((this.mUIHouseholdQuoteWindow == null))
                {
                    this.mUIHouseholdQuoteWindow = new UIHouseholdQuoteWindow(this);
                }
                return this.mUIHouseholdQuoteWindow;
            }
        }

        #endregion

        #region Fields

        private UIHouseholdQuoteWindow mUIHouseholdQuoteWindow;

        #endregion
    }
}