namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOptionsMenuItem1 : WinMenuItem
    {
        public UIOptionsMenuItem1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Options";
            this.WindowTitles.Add("Policy: autotest");

            #endregion
        }

        #region Properties

        public UILinksMenuItem1 UILinksMenuItem
        {
            get
            {
                if ((this.mUILinksMenuItem == null))
                {
                    this.mUILinksMenuItem = new UILinksMenuItem1(this);
                }
                return this.mUILinksMenuItem;
            }
        }

        public WinMenuItem UIPrintaBarcodeMenuItem
        {
            get
            {
                if ((this.mUIPrintaBarcodeMenuItem == null))
                {
                    this.mUIPrintaBarcodeMenuItem = new WinMenuItem(this);

                    #region Search Criteria

                    this.mUIPrintaBarcodeMenuItem.SearchProperties[UITestControl.PropertyNames.Name] = "Print a Barcode";
                    this.mUIPrintaBarcodeMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIPrintaBarcodeMenuItem.WindowTitles.Add("Policy: autotest");

                    #endregion
                }
                return this.mUIPrintaBarcodeMenuItem;
            }
        }

        public UILinksMenuLinks UILinksMenuItem1
        {
            get
            {
                if ((this.mUILinksMenuItem1 == null))
                {
                    this.mUILinksMenuItem1 = new UILinksMenuLinks(this);
                }
                return this.mUILinksMenuItem1;
            }
        }

        public UILinksMenuItem2 UILinksMenuItem2
        {
            get
            {
                if ((this.mUILinksMenuItem2 == null))
                {
                    this.mUILinksMenuItem2 = new UILinksMenuItem2(this);
                }
                return this.mUILinksMenuItem2;
            }
        }

        #endregion

        #region Fields

        private UILinksMenuItem1 mUILinksMenuItem;

        private WinMenuItem mUIPrintaBarcodeMenuItem;

        private UILinksMenuLinks mUILinksMenuItem1;

        private UILinksMenuItem2 mUILinksMenuItem2;

        #endregion
    }
}