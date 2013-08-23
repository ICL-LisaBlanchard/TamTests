namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIWindowsSecurityWindow1 : WinWindow
    {
        public UIWindowsSecurityWindow1()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Connect to www.insur-econnect.com";

            #endregion
        }

        #region Properties

        public UIItemListItem1 UIItemListItem
        {
            get
            {
                if ((this.mUIItemListItem == null))
                {
                    this.mUIItemListItem = new UIItemListItem1(this);
                }
                return this.mUIItemListItem;
            }
        }

        public UIWindowsSecurityPane1 UIWindowsSecurityPane
        {
            get
            {
                if ((this.mUIWindowsSecurityPane == null))
                {
                    this.mUIWindowsSecurityPane = new UIWindowsSecurityPane1(this);
                }
                return this.mUIWindowsSecurityPane;
            }
        }

        #endregion

        #region Fields

        private UIItemListItem1 mUIItemListItem;

        private UIWindowsSecurityPane1 mUIWindowsSecurityPane;

        #endregion
    }
}