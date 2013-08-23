namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIExitWindow : WinWindow
    {
        public UIExitWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "22";
            this.WindowTitles.Add("insur-E.tam");

            #endregion
        }

        #region Properties

        public WinButton UIExitButton
        {
            get
            {
                if ((this.mUIExitButton == null))
                {
                    this.mUIExitButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIExitButton.SearchProperties[UITestControl.PropertyNames.Name] = "Exit";
                    this.mUIExitButton.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUIExitButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIExitButton;

        #endregion
    }
}