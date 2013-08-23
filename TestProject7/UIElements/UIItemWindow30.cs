namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow30 : WinWindow
    {
        public UIItemWindow30(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32";
            this.WindowTitles.Add("Customer: autotest");

            #endregion
        }

        #region Properties

        public WinButton UIItemButton
        {
            get
            {
                if ((this.mUIItemButton == null))
                {
                    this.mUIItemButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIItemButton.WindowTitles.Add("Customer: autotest");

                    #endregion
                }
                return this.mUIItemButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIItemButton;

        #endregion
    }
}