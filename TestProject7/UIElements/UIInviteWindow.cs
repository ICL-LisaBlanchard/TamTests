namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIInviteWindow : WinWindow
    {
        public UIInviteWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "&Invite";

            #endregion
        }

        #region Properties

        public WinButton UIInviteButton
        {
            get
            {
                if ((this.mUIInviteButton == null))
                {
                    this.mUIInviteButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIInviteButton.SearchProperties[UITestControl.PropertyNames.Name] = "Invite";

                    #endregion
                }
                return this.mUIInviteButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIInviteButton;

        #endregion
    }
}