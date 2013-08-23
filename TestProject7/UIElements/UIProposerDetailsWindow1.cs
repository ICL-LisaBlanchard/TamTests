namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIProposerDetailsWindow1 : WinWindow
    {
        public UIProposerDetailsWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "41";
            this.WindowTitles.Add("Amend Risk");

            #endregion
        }

        #region Properties

        public WinButton UIProposerDetailsButton
        {
            get
            {
                if ((this.mUIProposerDetailsButton == null))
                {
                    this.mUIProposerDetailsButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIProposerDetailsButton.SearchProperties[UITestControl.PropertyNames.Name] = "Proposer Details...";
                    this.mUIProposerDetailsButton.WindowTitles.Add("Amend Risk");

                    #endregion
                }
                return this.mUIProposerDetailsButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIProposerDetailsButton;

        #endregion
    }
}