namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow75 : WinWindow
    {
        
        public UIItemWindow75(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ListView20WndClass";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "2";
            this.WindowTitles.Add("Renewals: New Business Accept");
            #endregion
        }
        
        #region Properties
        public WinClient UIRenewalsNewBusinessAClient
        {
            get
            {
                if ((this.mUIRenewalsNewBusinessAClient == null))
                {
                    this.mUIRenewalsNewBusinessAClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIRenewalsNewBusinessAClient.WindowTitles.Add("Renewals: New Business Accept");
                    #endregion
                }
                return this.mUIRenewalsNewBusinessAClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIRenewalsNewBusinessAClient;
        #endregion
    }
}