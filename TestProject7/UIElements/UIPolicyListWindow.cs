namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPolicyListWindow : WinWindow
    {
        
        public UIPolicyListWindow(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32769";
            this.WindowTitles.Add("Policy: autotest autotest");
            #endregion
        }
        
        #region Properties
        public UIOptionsWindow UIOptionsWindow
        {
            get
            {
                if ((this.mUIOptionsWindow == null))
                {
                    this.mUIOptionsWindow = new UIOptionsWindow(this);
                }
                return this.mUIOptionsWindow;
            }
        }
        
        public UIDetailWindow UIDetailWindow
        {
            get
            {
                if ((this.mUIDetailWindow == null))
                {
                    this.mUIDetailWindow = new UIDetailWindow(this);
                }
                return this.mUIDetailWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIOptionsWindow mUIOptionsWindow;
        
        private UIDetailWindow mUIDetailWindow;
        #endregion
    }
}