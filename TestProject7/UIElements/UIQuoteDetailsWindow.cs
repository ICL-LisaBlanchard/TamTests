namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIQuoteDetailsWindow : WinWindow
    {
        public UIQuoteDetailsWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "1";
            this.WindowTitles.Add("Quote Results");

            #endregion
        }

        #region Properties

        public WinGroup UIQuoteDetailsGroup
        {
            get
            {
                if ((this.mUIQuoteDetailsGroup == null))
                {
                    this.mUIQuoteDetailsGroup = new WinGroup(this);

                    #region Search Criteria

                    this.mUIQuoteDetailsGroup.SearchProperties[UITestControl.PropertyNames.Name] = "Quote Details";
                    this.mUIQuoteDetailsGroup.WindowTitles.Add("Quote Results");

                    #endregion
                }
                return this.mUIQuoteDetailsGroup;
            }
        }

        #endregion

        #region Fields

        private WinGroup mUIQuoteDetailsGroup;

        #endregion
    }
}