namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIFilterWindow2 : WinWindow
    {
        public UIFilterWindow2(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "9";
            this.WindowTitles.Add("insur-E.tam");

            #endregion
        }

        #region Properties

        public WinButton UIFilterButton 
        {
            get
            {
                if ((this.mUIFilterButton == null))
                {
                    this.mUIFilterButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIFilterButton.SearchProperties[UITestControl.PropertyNames.Name] = "Filter...";
                    this.mUIFilterButton.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUIFilterButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIFilterButton;

        #endregion
    }
}