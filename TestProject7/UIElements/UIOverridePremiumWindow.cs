namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOverridePremiumWindow : WinWindow
    {
        public UIOverridePremiumWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Override Premium";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Override Premium");

            #endregion
        }

        #region Properties

        public UIItemWindow49 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow49(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIOKWindow21 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow21(this);
                }
                return this.mUIOKWindow;
            }
        }

        public UIItemWindow120 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow120(this);
                }
                return this.mUIItemWindow1;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow49 mUIItemWindow;

        private UIOKWindow21 mUIOKWindow;

        private UIItemWindow120 mUIItemWindow1;

        #endregion
    }
}