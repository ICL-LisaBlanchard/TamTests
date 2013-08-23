namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UILookupWindow1 : WinWindow
    {
        public UILookupWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "8";
            this.SearchProperties[UITestControl.PropertyNames.Instance] = "2";
            this.WindowTitles.Add("insur-E.tam");

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
                    this.mUILookupButton.WindowTitles.Add("insur-E.tam");

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