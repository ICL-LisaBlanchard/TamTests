namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow121 : WinWindow
    {
        
        public UIItemWindow121(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6UserControlDC";
            this.WindowTitles.Add("New Policy: AUTOAU1");
            #endregion
        }
        
        #region Properties
        public WinClient UINewPolicyDetailClient
        {
            get
            {
                if ((this.mUINewPolicyDetailClient == null))
                {
                    this.mUINewPolicyDetailClient = new WinClient(this);
                    #region Search Criteria
                    this.mUINewPolicyDetailClient.WindowTitles.Add("New Policy: AUTOAU1");
                    #endregion
                }
                return this.mUINewPolicyDetailClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUINewPolicyDetailClient;
        #endregion
    }
}