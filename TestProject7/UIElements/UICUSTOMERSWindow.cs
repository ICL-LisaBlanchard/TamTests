namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICUSTOMERSWindow : WinWindow
    {
        
        public UICUSTOMERSWindow(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32768";
            #endregion
        }
        
        #region Properties
        public UIItemWindow3 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow3(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UICancelWindow UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UICancelWindow(this);
                }
                return this.mUICancelWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow3 mUIItemWindow;
        
        private UICancelWindow mUICancelWindow;
        #endregion
    }
}