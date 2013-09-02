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

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Renewal Accept";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Renewal Accept");

            #endregion
        }

        #region Properties

        public UIItemWindow UIAlternativeWindow
        {
            get
            {
                if ((this.mUIAlternativeWindow == null))
                {
                    this.mUIAlternativeWindow = new UIItemWindow(this, "1");
                }
                return this.mUIAlternativeWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, "4");
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIAlternativeWindow;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}