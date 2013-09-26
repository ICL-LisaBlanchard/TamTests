namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIWindowsSecurityWindow : WinWindow
    {
        public UIWindowsSecurityWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Windows Security";
            WindowTitles.Add("Windows Security");

            #endregion
        }

        #region Properties

        public UIItemUserDetails UIItemListItem
        {
            get
            {
                if ((mUIItemListItem == null))
                {
                    mUIItemListItem = new UIItemUserDetails(this);
                }
                return mUIItemListItem;
            }
        }

        public UIPane UIWindowsSecurityPane
        {
            get
            {
                if ((mUIWindowsSecurityPane == null))
                {
                    mUIWindowsSecurityPane = new UIPane(this, "Windows Security");
                }
                return mUIWindowsSecurityPane;
            }
        }

        #endregion

        #region Fields

        private UIItemUserDetails mUIItemListItem;

        private UIPane mUIWindowsSecurityPane;

        #endregion
    }
}