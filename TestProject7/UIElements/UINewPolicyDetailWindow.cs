namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UINewPolicyDetailWindow : WinWindow
    {
        
        public UINewPolicyDetailWindow(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32770";
            this.WindowTitles.Add("New Policy: AUTOAU1");
            this.WindowTitles.Add("Policy: autotest autotest");
            #endregion
        }
        
        #region Properties
        public UIItemWindow6 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow6(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow12 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow12(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UIOKWindow4 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow4(this);
                }
                return this.mUIOKWindow;
            }
        }
        
        public UIItemWindow21 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow21(this);
                }
                return this.mUIItemWindow2;
            }
        }
        
        public UIItemWindow111 UIItemWindow11
        {
            get
            {
                if ((this.mUIItemWindow11 == null))
                {
                    this.mUIItemWindow11 = new UIItemWindow111(this);
                }
                return this.mUIItemWindow11;
            }
        }
        
        public UICancelWindow2 UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UICancelWindow2(this);
                }
                return this.mUICancelWindow;
            }
        }
        
        public UIItemWindow121 UIItemWindow12
        {
            get
            {
                if ((this.mUIItemWindow12 == null))
                {
                    this.mUIItemWindow12 = new UIItemWindow121(this);
                }
                return this.mUIItemWindow12;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow6 mUIItemWindow;
        
        private UIItemWindow12 mUIItemWindow1;
        
        private UIOKWindow4 mUIOKWindow;
        
        private UIItemWindow21 mUIItemWindow2;
        
        private UIItemWindow111 mUIItemWindow11;
        
        private UICancelWindow2 mUICancelWindow;
        
        private UIItemWindow121 mUIItemWindow12;
        #endregion
    }
}