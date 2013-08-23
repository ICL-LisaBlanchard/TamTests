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

        public UIItemListItem UIItemListItem
        {
            get
            {
                if ((this.mUIItemListItem == null))
                {
                    this.mUIItemListItem = new UIItemListItem(this);
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

        private UIItemListItem mUIItemListItem;

        private UIWindowsSecurityPane mUIWindowsSecurityPane;

        #endregion
    }
}