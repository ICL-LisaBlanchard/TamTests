namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRenewalsNewBusinessAWindow1 : WinWindow
    {
        
        public UIRenewalsNewBusinessAWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Renewals: New Business Accept";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Renewals: New Business Accept");
            #endregion
        }
        
        #region Properties
        public UIItemWindow75 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow75(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIAcceptWindow3 UIAcceptWindow
        {
            get
            {
                if ((this.mUIAcceptWindow == null))
                {
                    this.mUIAcceptWindow = new UIAcceptWindow3(this);
                }
                return this.mUIAcceptWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow75 mUIItemWindow;
        
        private UIAcceptWindow3 mUIAcceptWindow;
        #endregion
    }
}