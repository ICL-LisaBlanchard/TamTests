namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIProposerDetailsWindow : WinWindow
    {
        public UIProposerDetailsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Proposer Details";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Proposer Details");

            #endregion
        }

        #region Properties

        public UIItemWindow8 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow8(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow13 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow13(this);
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow22 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow22(this);
                }
                return this.mUIItemWindow2;
            }
        }

        public UIItemWindow31 UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow31(this);
                }
                return this.mUIItemWindow3;
            }
        }

        public UILookupWindow UILookupWindow
        {
            get
            {
                if ((this.mUILookupWindow == null))
                {
                    this.mUILookupWindow = new UILookupWindow(this);
                }
                return this.mUILookupWindow;
            }
        }

        public UIItemWindow41 UIItemWindow4
        {
            get
            {
                if ((this.mUIItemWindow4 == null))
                {
                    this.mUIItemWindow4 = new UIItemWindow41(this);
                }
                return this.mUIItemWindow4;
            }
        }

        public UIItemWindow51 UIItemWindow5
        {
            get
            {
                if ((this.mUIItemWindow5 == null))
                {
                    this.mUIItemWindow5 = new UIItemWindow51(this);
                }
                return this.mUIItemWindow5;
            }
        }

        public UIOKWindow8 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow8(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow8 mUIItemWindow;

        private UIItemWindow13 mUIItemWindow1;

        private UIItemWindow22 mUIItemWindow2;

        private UIItemWindow31 mUIItemWindow3;

        private UILookupWindow mUILookupWindow;

        private UIItemWindow41 mUIItemWindow4;

        private UIItemWindow51 mUIItemWindow5;

        private UIOKWindow8 mUIOKWindow;

        #endregion
    }
}