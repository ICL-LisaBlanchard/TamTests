namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIMicrosoftWordViewerWindow : WinWindow
    {
        
        public UIMicrosoftWordViewerWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Microsoft Word Viewer";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "OpusApp";
            this.WindowTitles.Add("Microsoft Word Viewer");
            #endregion
        }
        
        #region Properties
        public WinTitleBar UIMicrosoftWordViewerTitleBar
        {
            get
            {
                if ((this.mUIMicrosoftWordViewerTitleBar == null))
                {
                    this.mUIMicrosoftWordViewerTitleBar = new WinTitleBar(this);
                    #region Search Criteria
                    this.mUIMicrosoftWordViewerTitleBar.WindowTitles.Add("Microsoft Word Viewer");
                    #endregion
                }
                return this.mUIMicrosoftWordViewerTitleBar;
            }
        }
        
        public UIItemWindow77 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow77(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private WinTitleBar mUIMicrosoftWordViewerTitleBar;
        
        private UIItemWindow77 mUIItemWindow;
        #endregion
    }
}