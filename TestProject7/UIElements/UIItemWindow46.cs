namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow46 : WinWindow
    {
        public UIItemWindow46(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[PropertyNames.AccessibleName] = "Ribbon";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "NetUIHWND";
            this.WindowTitles.Add("Demands&Needs(HouseholdBuildings&Contents) [Compatibility Mode] - Microsoft Word");

            #endregion
        }

        #region Properties

        public UIRibbonPropertyPage1 UIRibbonPropertyPage
        {
            get
            {
                if ((this.mUIRibbonPropertyPage == null))
                {
                    this.mUIRibbonPropertyPage = new UIRibbonPropertyPage1(this);
                }
                return this.mUIRibbonPropertyPage;
            }
        }

        #endregion

        #region Fields

        private UIRibbonPropertyPage1 mUIRibbonPropertyPage;

        #endregion
    }
}