namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBlankPageWindowsInteTitleBar : WinTitleBar
    {
        public UIBlankPageWindowsInteTitleBar(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
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