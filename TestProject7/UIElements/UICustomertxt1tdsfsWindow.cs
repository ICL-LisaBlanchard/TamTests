namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICustomertxt1tdsfsWindow : WinWindow
    {
        
        public UICustomertxt1tdsfsWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            #endregion
        }
        
        #region Properties
        public UICUSTOMERSWindow UICUSTOMERSWindow
        {
            get
            {
                if ((this.mUICUSTOMERSWindow == null))
                {
                    this.mUICUSTOMERSWindow = new UICUSTOMERSWindow(this);
                }
                return this.mUICUSTOMERSWindow;
            }
        }
        
        public UIAddWindow UIAddWindow
        {
            get
            {
                if ((this.mUIAddWindow == null))
                {
                    this.mUIAddWindow = new UIAddWindow(this);
                }
                return this.mUIAddWindow;
            }
        }
        
        public UINewCustomerDetailWindow UINewCustomerDetailWindow
        {
            get
            {
                if ((this.mUINewCustomerDetailWindow == null))
                {
                    this.mUINewCustomerDetailWindow = new UINewCustomerDetailWindow(this);
                }
                return this.mUINewCustomerDetailWindow;
            }
        }
        
        public UIItemWindow5 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow5(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UINewPolicyDetailWindow UINewPolicyDetailWindow
        {
            get
            {
                if ((this.mUINewPolicyDetailWindow == null))
                {
                    this.mUINewPolicyDetailWindow = new UINewPolicyDetailWindow(this);
                }
                return this.mUINewPolicyDetailWindow;
            }
        }
        
        public UIPolicyListWindow UIPolicyListWindow
        {
            get
            {
                if ((this.mUIPolicyListWindow == null))
                {
                    this.mUIPolicyListWindow = new UIPolicyListWindow(this);
                }
                return this.mUIPolicyListWindow;
            }
        }
        
        public UIApplicationMenuBar UIApplicationMenuBar
        {
            get
            {
                if ((this.mUIApplicationMenuBar == null))
                {
                    this.mUIApplicationMenuBar = new UIApplicationMenuBar(this);
                }
                return this.mUIApplicationMenuBar;
            }
        }
        #endregion
        
        #region Fields
        private UICUSTOMERSWindow mUICUSTOMERSWindow;
        
        private UIAddWindow mUIAddWindow;
        
        private UINewCustomerDetailWindow mUINewCustomerDetailWindow;
        
        private UIItemWindow5 mUIItemWindow;
        
        private UINewPolicyDetailWindow mUINewPolicyDetailWindow;
        
        private UIPolicyListWindow mUIPolicyListWindow;
        
        private UIApplicationMenuBar mUIApplicationMenuBar;
        #endregion
    }
}