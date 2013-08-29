namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIConfirmWindow1 : WinWindow
    {
        public UIConfirmWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "5";
            this.SearchProperties[UITestControl.PropertyNames.Instance] = "2";
            this.WindowTitles.Add("Policy Detail Confirmation");

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
                    this.mUIConfirmButton.WindowTitles.Add("Policy Detail Confirmation");

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