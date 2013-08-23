namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
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

        public UIAlternativeWindow UIAlternativeWindow
        {
            get
            {
                if ((this.mUIAlternativeWindow == null))
                {
                    this.mUIAlternativeWindow = new UIAlternativeWindow(this);
                }
                return this.mUIAlternativeWindow;
            }
        }

        public UIOKWindow35 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow35(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIAlternativeWindow mUIAlternativeWindow;

        private UIOKWindow35 mUIOKWindow;

        #endregion
    }
}