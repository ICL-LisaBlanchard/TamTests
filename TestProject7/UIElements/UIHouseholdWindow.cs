namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIHouseholdWindow : WinWindow
    {
        public UIHouseholdWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "7";
            this.WindowTitles.Add("Product Selection");

            #endregion
        }

        #region Properties

        public WinRadioButton UIHouseholdRadioButton
        {
            get
            {
                if ((this.mUIHouseholdRadioButton == null))
                {
                    this.mUIHouseholdRadioButton = new WinRadioButton(this);

                    #region Search Criteria

                    this.mUIHouseholdRadioButton.SearchProperties[UITestControl.PropertyNames.Name] = "Household";
                    this.mUIHouseholdRadioButton.WindowTitles.Add("Product Selection");

                    #endregion
                }
                return this.mUIHouseholdRadioButton;
            }
        }

        #endregion

        #region Fields

        private WinRadioButton mUIHouseholdRadioButton;

        #endregion
    }
}