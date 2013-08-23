namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRebrokeResultsScreenWindow : WinWindow
    {
        public UIRebrokeResultsScreenWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Rebroke Results Screen";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Rebroke Results Screen");

            #endregion
        }

        #region Properties

        public UIItemWindow67 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow67(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIOKWindow34 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow34(this);
                }
                return this.mUIOKWindow;
            }
        }

        public UIItemWindow128 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow128(this);
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow216 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow216(this);
                }
                return this.mUIItemWindow2;
            }
        }

        public UISelectAlternativeWindow UISelectAlternativeWindow
        {
            get
            {
                if ((this.mUISelectAlternativeWindow == null))
                {
                    this.mUISelectAlternativeWindow = new UISelectAlternativeWindow(this);
                }
                return this.mUISelectAlternativeWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow67 mUIItemWindow;

        private UIOKWindow34 mUIOKWindow;

        private UIItemWindow128 mUIItemWindow1;

        private UIItemWindow216 mUIItemWindow2;

        private UISelectAlternativeWindow mUISelectAlternativeWindow;

        #endregion
    }
}