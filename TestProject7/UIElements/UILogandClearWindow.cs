namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UILogandClearWindow : WinWindow
    {
        public UILogandClearWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "5";
            this.WindowTitles.Add("insur-E.tam");

            #endregion
        }

        #region Properties

        public WinButton UILogandClearButton
        {
            get
            {
                if ((this.mUILogandClearButton == null))
                {
                    this.mUILogandClearButton = new WinButton(this);

                    #region Search Criteria

                    this.mUILogandClearButton.SearchProperties[UITestControl.PropertyNames.Name] = "Log and Clear";
                    this.mUILogandClearButton.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUILogandClearButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUILogandClearButton;

        #endregion
    }
}