namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow76 : WinWindow
    {
        
        public UIItemWindow76(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "4";
            this.WindowTitles.Add("New Customer: DAFS001");
            #endregion
        }
        
        #region Properties
        public WinGroup UIItemGroup
        {
            get
            {
                if ((this.mUIItemGroup == null))
                {
                    this.mUIItemGroup = new WinGroup(this);
                    #region Search Criteria
                    this.mUIItemGroup.WindowTitles.Add("New Customer: DAFS001");
                    #endregion
                }
                return this.mUIItemGroup;
            }
        }
        #endregion
        
        #region Fields
        private WinGroup mUIItemGroup;
        #endregion
    }
}