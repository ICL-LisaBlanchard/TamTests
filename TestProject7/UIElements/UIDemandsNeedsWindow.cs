namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDemandsNeedsWindow : WinWindow
    {
        public UIDemandsNeedsWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "8";
            this.WindowTitles.Add("Quote Results");

            #endregion
        }

        #region Properties

        public WinButton UIDemandsNeedsButton
        {
            get
            {
                if ((this.mUIDemandsNeedsButton == null))
                {
                    this.mUIDemandsNeedsButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIDemandsNeedsButton.SearchProperties[UITestControl.PropertyNames.Name] = "Demands & Needs";
                    this.mUIDemandsNeedsButton.WindowTitles.Add("Quote Results");

                    #endregion
                }
                return this.mUIDemandsNeedsButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIDemandsNeedsButton;

        #endregion
    }
}