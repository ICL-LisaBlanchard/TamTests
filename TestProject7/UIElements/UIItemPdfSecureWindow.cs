namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIItemPdfSecureWindow : WinWindow
    {
        public UIItemPdfSecureWindow()
        {
            #region Search Criteria

            //this.SearchProperties[WinWindow.PropertyNames.Name] = "201309~1.pdf (SECURED) - Foxit Reader - [201309~1.pdf (SECURED)]";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "classFoxitReader";
            //this.WindowTitles.Add("201309~1.pdf (SECURED) - Foxit Reader - [201309~1.pdf (SECURED)]");

            #endregion
        }

        #region Properties

        public UIApplicationMenuBar UIApplicationMenuBar
        {
            get
            {
                if ((this.mUIApplicationMenuBar == null))
                {
                    this.mUIApplicationMenuBar = new UIApplicationMenuBar(this, "Application");
                }
                return this.mUIApplicationMenuBar;
            }
        }

        public UITitleBar UITitleBar
        {
            get
            {
                if ((this.mUITitleBar == null))
                {
                    this.mUITitleBar = new UITitleBar(this);
                }
                return this.mUITitleBar;
            }
        }

        #endregion

        #region Fields

        private UIApplicationMenuBar mUIApplicationMenuBar;

        private UITitleBar mUITitleBar;

        #endregion
    }
}