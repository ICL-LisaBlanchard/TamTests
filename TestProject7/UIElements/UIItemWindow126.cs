namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow126 : WinWindow
    {
        public UIItemWindow126(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "1";
            this.WindowTitles.Add("Regress IETam Policy");

            #endregion
        }

        #region Properties

        public WinMenuBar UISystemMenuBar
        {
            get
            {
                if ((this.mUISystemMenuBar == null))
                {
                    this.mUISystemMenuBar = new WinMenuBar(this);

                    #region Search Criteria

                    this.mUISystemMenuBar.SearchProperties[UITestControl.PropertyNames.Name] = "System";
                    this.mUISystemMenuBar.WindowTitles.Add("Regress IETam Policy");

                    #endregion
                }
                return this.mUISystemMenuBar;
            }
        }

        #endregion

        #region Fields

        private WinMenuBar mUISystemMenuBar;

        #endregion
    }
}