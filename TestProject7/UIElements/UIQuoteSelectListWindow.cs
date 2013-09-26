namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIQuoteSelectListWindow : WinWindow
    {
        public UIQuoteSelectListWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Quote Select List";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("Quote Select List");

            #endregion
        }

        #region Properties

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((mUICancelWindow == null))
                {
                    mUICancelWindow = new UIItemWindow(this, "1");
                }
                return mUICancelWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUICancelWindow;

        #endregion
    }
}