namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOptionsWindow : WinWindow
    {
        public UIOptionsWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "7";
            this.WindowTitles.Add("Policy: autotest autotest");

            #endregion
        }

        #region Properties

        public WinButton UIOptionsButton 
        {
            get
            {
                if ((this.mUIOptionsButton == null))
                {
                    this.mUIOptionsButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIOptionsButton.SearchProperties[UITestControl.PropertyNames.Name] = "Options";
                    this.mUIOptionsButton.WindowTitles.Add("Policy: autotest autotest");

                    #endregion
                }
                return this.mUIOptionsButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIOptionsButton;

        #endregion
    }
}