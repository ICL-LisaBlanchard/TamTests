namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow74 : WinWindow
    {
        
        public UIItemWindow74(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ListView20WndClass";
            this.WindowTitles.Add("Household Rebroke Results");
            #endregion
        }
        
        #region Properties
        public WinClient UIHouseholdRebrokeResuClient
        {
            get
            {
                if ((this.mUIHouseholdRebrokeResuClient == null))
                {
                    this.mUIHouseholdRebrokeResuClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIHouseholdRebrokeResuClient.WindowTitles.Add("Household Rebroke Results");
                    #endregion
                }
                return this.mUIHouseholdRebrokeResuClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIHouseholdRebrokeResuClient;
        #endregion
    }
}