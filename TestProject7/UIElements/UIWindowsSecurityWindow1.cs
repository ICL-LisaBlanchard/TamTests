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

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Connect to www.insur-econnect.com";

            #endregion
        }

        #region Properties

        public UIItemUserDetails UIItemListItem
        {
            get
            {
                if ((this.mUIItemListItem == null))
                {
                    this.mUIItemListItem = new UIItemUserDetails(this);
                }
                return this.mUIItemListItem;
            }
        }

        public UIPane UIWindowsSecurityPane
        {
            get
            {
                if ((this.mUIWindowsSecurityPane == null))
                {
                    this.mUIWindowsSecurityPane = new UIPane(this, "Connect to www.insur-econnect.com");
                }
                return this.mUIWindowsSecurityPane;
            }
        }

        #endregion

        #region Fields

        private UIItemUserDetails mUIItemListItem;

        private UIPane mUIWindowsSecurityPane;

        #endregion
    }
}