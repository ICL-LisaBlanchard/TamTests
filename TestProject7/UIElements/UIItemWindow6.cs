namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow6 : WinWindow
    {
        
        public UIItemWindow6(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6UserControlDC";
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "13";
            this.WindowTitles.Add("New Policy: AUTOAU1");
            #endregion
        }
        
        #region Properties
        public UIItemClient UIItemClient
        {
            get
            {
                if ((this.mUIItemClient == null))
                {
                    this.mUIItemClient = new UIItemClient(this);
                }
                return this.mUIItemClient;
            }
        }
        #endregion
        
        #region Fields
        private UIItemClient mUIItemClient;
        #endregion
    }
}