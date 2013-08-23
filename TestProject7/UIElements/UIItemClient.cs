namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemClient : WinClient
    {
        
        public UIItemClient(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("New Policy: AUTOAU1");
            #endregion
        }
        
        #region Properties
        public WinWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new WinWindow(this);
                    #region Search Criteria
                    this.mUIItemWindow.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6TextBox";
                    this.mUIItemWindow.WindowTitles.Add("New Policy: AUTOAU1");
                    #endregion
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private WinWindow mUIItemWindow;
        #endregion
    }
}