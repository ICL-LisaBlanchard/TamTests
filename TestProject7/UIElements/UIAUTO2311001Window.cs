namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAUTO2311001Window : WinWindow
    {
        
        public UIAUTO2311001Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "AUTO231-1001";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("AUTO231-1001");
            #endregion
        }
        
        #region Properties
        public UIRenewPolicyWindow4 UIRenewPolicyWindow
        {
            get
            {
                if ((this.mUIRenewPolicyWindow == null))
                {
                    this.mUIRenewPolicyWindow = new UIRenewPolicyWindow4(this);
                }
                return this.mUIRenewPolicyWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIRenewPolicyWindow4 mUIRenewPolicyWindow;
        #endregion
    }
}