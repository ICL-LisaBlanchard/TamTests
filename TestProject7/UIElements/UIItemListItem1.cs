namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemListItem1 : WinListItem
    {
        
        public UIItemListItem1(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
        }
        
        #region Properties
        public WinEdit UIUsernameEdit
        {
            get
            {
                if ((this.mUIUsernameEdit == null))
                {
                    this.mUIUsernameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIUsernameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "User name";
                    #endregion
                }
                return this.mUIUsernameEdit;
            }
        }
        
        public WinEdit UIPasswordEdit
        {
            get
            {
                if ((this.mUIPasswordEdit == null))
                {
                    this.mUIPasswordEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIPasswordEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Password";
                    #endregion
                }
                return this.mUIPasswordEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIUsernameEdit;
        
        private WinEdit mUIPasswordEdit;
        #endregion
    }
}