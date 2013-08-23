namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIComprehensiveWindow : WinWindow
    {
        public UIComprehensiveWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "23";
            this.WindowTitles.Add("Quote Results");

            #endregion
        }

        #region Properties

        public WinRadioButton UIComprehensiveRadioButton
        {
            get
            {
                if ((this.mUIComprehensiveRadioButton == null))
                {
                    this.mUIComprehensiveRadioButton = new WinRadioButton(this);

                    #region Search Criteria

                    this.mUIComprehensiveRadioButton.SearchProperties[UITestControl.PropertyNames.Name] = "Comprehensive";
                    this.mUIComprehensiveRadioButton.WindowTitles.Add("Quote Results");

                    #endregion
                }
                return this.mUIComprehensiveRadioButton;
            }
        }

        #endregion

        #region Fields

        private WinRadioButton mUIComprehensiveRadioButton;

        #endregion
    }
}