namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UINewCustomerDAFS001Window : WinWindow
    {
        
        public UINewCustomerDAFS001Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "New Customer: DAFS001";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            this.WindowTitles.Add("New Customer: DAFS001");
            #endregion
        }
        
        #region Properties
        public UINewCustomerDetailWindow1 UINewCustomerDetailWindow
        {
            get
            {
                if ((this.mUINewCustomerDetailWindow == null))
                {
                    this.mUINewCustomerDetailWindow = new UINewCustomerDetailWindow1(this);
                }
                return this.mUINewCustomerDetailWindow;
            }
        }
        #endregion
        
        #region Fields
        private UINewCustomerDetailWindow1 mUINewCustomerDetailWindow;
        #endregion
    }
}