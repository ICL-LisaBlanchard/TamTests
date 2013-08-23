namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIEDIMatchWindow : WinWindow
    {
        public UIEDIMatchWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "7";
            this.WindowTitles.Add("insur-E.tam");

            #endregion
        }

        #region Properties

        public WinButton UIEDIMatchButton
        {
            get
            {
                if ((this.mUIEDIMatchButton == null))
                {
                    this.mUIEDIMatchButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIEDIMatchButton.SearchProperties[UITestControl.PropertyNames.Name] = "EDI Match...";
                    this.mUIEDIMatchButton.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUIEDIMatchButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIEDIMatchButton;

        #endregion
    }
}