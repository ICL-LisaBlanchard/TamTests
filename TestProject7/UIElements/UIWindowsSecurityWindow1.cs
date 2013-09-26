namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIWindowsSecurityWindow1 : WinWindow
    {
        public UIWindowsSecurityWindow1()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Connect to www.insur-econnect.com";

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
                    mUIWindowsSecurityPane = new UIPane(this, "Connect to www.insur-econnect.com");
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