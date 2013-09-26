namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPersonalLinesWindow : WinWindow
    {
        public UIPersonalLinesWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Personal Lines";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            WindowTitles.Add("Personal Lines");

            #endregion
        }

        #region Properties

        public UIHouseholdQuoteWindow UIHouseholdQuoteWindow
        {
            get
            {
                if ((mUIHouseholdQuoteWindow == null))
                {
                    mUIHouseholdQuoteWindow = new UIHouseholdQuoteWindow(this);
                }
                return mUIHouseholdQuoteWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, "2");
                }
                return mUIOKWindow;
            }
        }

        public UIItemWindow UIYesWindow
        {
            get
            {
                return new UIItemWindow(this, "6");
            }
        }

        #endregion

        #region Fields

        private UIHouseholdQuoteWindow mUIHouseholdQuoteWindow;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}