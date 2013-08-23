namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRibbonPropertyPage1 : WinControl
    {
        public UIRibbonPropertyPage1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Ribbon";
            this.SearchProperties[UITestControl.PropertyNames.ControlType] = "PropertyPage";
            this.WindowTitles.Add("Demands&Needs(HouseholdBuildings&Contents) [Compatibility Mode] - Microsoft Word");

            #endregion
        }

        #region Properties

        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);

                    #region Search Criteria

                    this.mUICloseButton.SearchProperties[UITestControl.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Demands&Needs(HouseholdBuildings&Contents) [Compatibility Mode] - Microsoft Word");

                    #endregion
                }
                return this.mUICloseButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUICloseButton;

        #endregion
    }
}