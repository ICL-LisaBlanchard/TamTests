namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UILookupWindow2 : WinWindow
    {
        public UILookupWindow2(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "8";
            this.WindowTitles.Add("Policy Detail Confirmation");

            #endregion
        }

        #region Properties

        public WinButton UILookupButton
        {
            get
            {
                if ((this.mUILookupButton == null))
                {
                    this.mUILookupButton = new WinButton(this);

                    #region Search Criteria

                    this.mUILookupButton.SearchProperties[UITestControl.PropertyNames.Name] = "Lookup...";
                    this.mUILookupButton.WindowTitles.Add("Policy Detail Confirmation");

                    #endregion
                }
                return this.mUILookupButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUILookupButton;

        #endregion
    }
}