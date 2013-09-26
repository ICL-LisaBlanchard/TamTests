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

            //SearchProperties[WinWindow.PropertyNames.Name] = "201309~1.pdf (SECURED) - Foxit Reader - [201309~1.pdf (SECURED)]";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "classFoxitReader";
            //WindowTitles.Add("201309~1.pdf (SECURED) - Foxit Reader - [201309~1.pdf (SECURED)]");

            #endregion
        }

        #region Properties

        public UIApplicationMenuBar UIApplicationMenuBar
        {
            get
            {
                if ((mUIApplicationMenuBar == null))
                {
                    mUIApplicationMenuBar = new UIApplicationMenuBar(this, "Application");
                }
                return mUIApplicationMenuBar;
            }
        }

        public UITitleBar UITitleBar
        {
            get
            {
                if ((mUITitleBar == null))
                {
                    mUITitleBar = new UITitleBar(this);
                }
                return mUITitleBar;
            }
        }

        #endregion

        #region Fields

        private UIApplicationMenuBar mUIApplicationMenuBar;

        private UITitleBar mUITitleBar;

        #endregion
    }
}