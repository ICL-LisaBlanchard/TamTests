namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow115 : WinWindow
    {
        public UIItemWindow115(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "26";
            this.WindowTitles.Add("Policy: autotest");

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

                    this.mUIItemButton.WindowTitles.Add("Policy: autotest");

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