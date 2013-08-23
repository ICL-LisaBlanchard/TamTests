namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UINewCustomerDetailWindow1 : WinWindow
    {
        
        public UINewCustomerDetailWindow1(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32769";
            this.WindowTitles.Add("New Customer: DAFS001");
            #endregion
        }
        
        #region Properties
        public UIItemWindow76 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow76(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow129 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow129(this);
                }
                return this.mUIItemWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow76 mUIItemWindow;
        
        private UIItemWindow129 mUIItemWindow1;
        #endregion
    }
}