namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIWindowsSecurityWindow : WinWindow
    {
        public UIWindowsSecurityWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Windows Security";
            this.WindowTitles.Add("Windows Security");

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

        public UIWindowsSecurityPane UIWindowsSecurityPane
        {
            get
            {
                if ((this.mUIWindowsSecurityPane == null))
                {
                    this.mUIWindowsSecurityPane = new UIWindowsSecurityPane(this);
                }
                return this.mUIWindowsSecurityPane;
            }
        }

        #endregion

        #region Fields

        private UIItemUserDetails mUIItemListItem;

        private UIWindowsSecurityPane mUIWindowsSecurityPane;

        #endregion
    }
}