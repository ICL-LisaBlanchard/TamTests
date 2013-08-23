namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow38 : WinWindow
    {
        public UIItemWindow38(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[PropertyNames.AccessibleName] = "Ribbon";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "NetUIHWND";
            this.WindowTitles.Add("Demands&Needs(Motor) [Compatibility Mode] - Microsoft Word");

            #endregion
        }

        #region Properties

        public UIRibbonPropertyPage UIRibbonPropertyPage
        {
            get
            {
                if ((this.mUIRibbonPropertyPage == null))
                {
                    this.mUIRibbonPropertyPage = new UIRibbonPropertyPage(this);
                }
                return this.mUIRibbonPropertyPage;
            }
        }

        #endregion

        #region Fields

        private UIRibbonPropertyPage mUIRibbonPropertyPage;

        #endregion
    }
}