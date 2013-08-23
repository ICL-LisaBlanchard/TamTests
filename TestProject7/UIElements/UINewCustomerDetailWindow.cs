namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UINewCustomerDetailWindow : WinWindow
    {
        
        public UINewCustomerDetailWindow(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32769";
            this.WindowTitles.Add("New Customer: AUTOAU1");
            this.WindowTitles.Add("Policy: autotest autotest");
            #endregion
        }
        
        #region Properties
        public UIItemWindow4 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow4(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow11 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow11(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UIOKWindow3 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow3(this);
                }
                return this.mUIOKWindow;
            }
        }
        
        public UICancelWindow1 UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UICancelWindow1(this);
                }
                return this.mUICancelWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow4 mUIItemWindow;
        
        private UIItemWindow11 mUIItemWindow1;
        
        private UIOKWindow3 mUIOKWindow;
        
        private UICancelWindow1 mUICancelWindow;
        #endregion
    }
}