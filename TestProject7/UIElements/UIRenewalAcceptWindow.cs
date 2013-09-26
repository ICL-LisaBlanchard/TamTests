namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIRenewalAcceptWindow : WinWindow
    {
        public UIRenewalAcceptWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Renewal Accept";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("Renewal Accept");

            #endregion
        }

        #region Properties

        public UIItemWindow UIAlternativeWindow
        {
            get
            {
                if ((mUIAlternativeWindow == null))
                {
                    mUIAlternativeWindow = new UIItemWindow(this, "1");
                }
                return mUIAlternativeWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, "4");
                }
                return mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIAlternativeWindow;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}