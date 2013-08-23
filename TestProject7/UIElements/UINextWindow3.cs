namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UINextWindow3 : WinWindow
    {
        public UINextWindow3(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "117";
            this.WindowTitles.Add("insur-E.tam");

            #endregion
        }

        #region Properties

        public WinButton UINextButton
        {
            get
            {
                if ((this.mUINextButton == null))
                {
                    this.mUINextButton = new WinButton(this);

                    #region Search Criteria

                    this.mUINextButton.SearchProperties[UITestControl.PropertyNames.Name] = "Next >";
                    this.mUINextButton.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUINextButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUINextButton;

        #endregion
    }
}