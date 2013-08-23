namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIFilterRenewalRecordsWindow : WinWindow
    {
        public UIFilterRenewalRecordsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Filter Renewal Records";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Filter Renewal Records");

            #endregion
        }

        #region Properties

        public UIItemWindow65 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow65(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow127 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow127(this);
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow215 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow215(this);
                }
                return this.mUIItemWindow2;
            }
        }

        public UIOKWindow30 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow30(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow65 mUIItemWindow;

        private UIItemWindow127 mUIItemWindow1;

        private UIItemWindow215 mUIItemWindow2;

        private UIOKWindow30 mUIOKWindow;

        #endregion
    }
}