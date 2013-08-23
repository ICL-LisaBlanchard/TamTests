namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIConfirmWindow : WinWindow
    {
        public UIConfirmWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "5";
            this.WindowTitles.Add("Policy Date / Time");

            #endregion
        }

        #region Properties

        public WinButton UIConfirmButton
        {
            get
            {
                if ((this.mUIConfirmButton == null))
                {
                    this.mUIConfirmButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIConfirmButton.SearchProperties[UITestControl.PropertyNames.Name] = "Confirm";
                    this.mUIConfirmButton.WindowTitles.Add("Policy Date / Time");

                    #endregion
                }
                return this.mUIConfirmButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIConfirmButton;

        #endregion
    }
}