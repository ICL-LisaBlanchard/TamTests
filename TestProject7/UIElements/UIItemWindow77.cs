namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow77 : WinWindow
    {
        
        public UIItemWindow77(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "_WwF";
            this.WindowTitles.Add("Microsoft Word Viewer");
            #endregion
        }
        
        #region Properties
        public WinClient UIMicrosoftWordViewerClient
        {
            get
            {
                if ((this.mUIMicrosoftWordViewerClient == null))
                {
                    this.mUIMicrosoftWordViewerClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIMicrosoftWordViewerClient.WindowTitles.Add("Microsoft Word Viewer");
                    #endregion
                }
                return this.mUIMicrosoftWordViewerClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIMicrosoftWordViewerClient;
        #endregion
    }
}