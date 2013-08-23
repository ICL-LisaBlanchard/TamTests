namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIApplicationMenuBar1 : WinMenuBar
    {
        public UIApplicationMenuBar1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Application";
            this.WindowTitles.Add("Policy: autotest");

            #endregion
        }

        #region Properties

        public UIOptionsMenuItem1 UIOptionsMenuItem
        {
            get
            {
                if ((this.mUIOptionsMenuItem == null))
                {
                    this.mUIOptionsMenuItem = new UIOptionsMenuItem1(this);
                }
                return this.mUIOptionsMenuItem;
            }
        }

        #endregion

        #region Fields

        private UIOptionsMenuItem1 mUIOptionsMenuItem;

        #endregion
    }
}