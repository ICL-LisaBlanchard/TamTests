namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAlternativeWindow : WinWindow
    {
        public UIAlternativeWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "1";
            this.WindowTitles.Add("Renewal Accept");

            #endregion
        }

        #region Properties

        public WinRadioButton UIAlternativeRadioButton
        {
            get
            {
                if ((this.mUIAlternativeRadioButton == null))
                {
                    this.mUIAlternativeRadioButton = new WinRadioButton(this);

                    #region Search Criteria

                    this.mUIAlternativeRadioButton.SearchProperties[UITestControl.PropertyNames.Name] = "Alternative";
                    this.mUIAlternativeRadioButton.WindowTitles.Add("Renewal Accept");

                    #endregion
                }
                return this.mUIAlternativeRadioButton;
            }
        }

        #endregion

        #region Fields

        private WinRadioButton mUIAlternativeRadioButton;

        #endregion
    }
}