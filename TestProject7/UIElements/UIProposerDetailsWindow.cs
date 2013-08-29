namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIProposerDetailsWindow : WinWindow
    {
        private const string WindowName = "Proposer Details";

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "1", instance: "2");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow(this, controlId: "2", instance: "2");
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow(this, controlId: "1", instance: "4");
                }
                return this.mUIItemWindow2;
            }
        }

        public UIItemWindow UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow(this, controlId: "1");
                }
                return this.mUIItemWindow3;
            }
        }

        public UIItemWindow UILookupWindow
        {
            get
            {
                if ((this.mUILookupWindow == null))
                {
                    this.mUILookupWindow = new UIItemWindow(this, controlId: "8");
                }
                return this.mUILookupWindow;
            }
        }

        public UIItemWindow UIItemWindow4
        {
            get
            {
                if ((this.mUIItemWindow4 == null))
                {
                    this.mUIItemWindow4 = new UIItemWindow(this, controlId: "7");
                }
                return this.mUIItemWindow4;
            }
        }

        public UIItemWindow UIItemWindow5
        {
            get
            {
                if ((this.mUIItemWindow5 == null))
                {
                    this.mUIItemWindow5 = new UIItemWindow(this, controlId: "5");
                }
                return this.mUIItemWindow5;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "12");
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIItemWindow2;

        private UIItemWindow mUIItemWindow3;

        private UIItemWindow mUILookupWindow;

        private UIItemWindow mUIItemWindow4;

        private UIItemWindow mUIItemWindow5;

        private UIItemWindow mUIOKWindow;

        #endregion

        public UIProposerDetailsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Proposer Details";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(WindowName);

            #endregion
        }
    }
}