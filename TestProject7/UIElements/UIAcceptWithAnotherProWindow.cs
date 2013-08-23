namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAcceptWithAnotherProWindow : WinWindow
    {
        public UIAcceptWithAnotherProWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Accept With Another Product";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Accept With Another Product");

            #endregion
        }

        #region Properties

        public UIItemWindow47 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow47(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow119 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow119(this);
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow213 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow213(this);
                }
                return this.mUIItemWindow2;
            }
        }

        public UIItemWindow310 UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow310(this);
                }
                return this.mUIItemWindow3;
            }
        }

        public UIItemWindow48 UIItemWindow4
        {
            get
            {
                if ((this.mUIItemWindow4 == null))
                {
                    this.mUIItemWindow4 = new UIItemWindow48(this);
                }
                return this.mUIItemWindow4;
            }
        }

        public UIOKWindow20 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow20(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow47 mUIItemWindow;

        private UIItemWindow119 mUIItemWindow1;

        private UIItemWindow213 mUIItemWindow2;

        private UIItemWindow310 mUIItemWindow3;

        private UIItemWindow48 mUIItemWindow4;

        private UIOKWindow20 mUIOKWindow;

        #endregion
    }
}