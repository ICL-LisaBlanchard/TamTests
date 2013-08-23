namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAWAPWindow : WinWindow
    {
        public UIAWAPWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "3";
            this.WindowTitles.Add("Quote Results");

            #endregion
        }

        #region Properties

        public WinButton UIAWAPButton
        {
            get
            {
                if ((this.mUIAWAPButton == null))
                {
                    this.mUIAWAPButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIAWAPButton.SearchProperties[UITestControl.PropertyNames.Name] = "AWAP";
                    this.mUIAWAPButton.WindowTitles.Add("Quote Results");

                    #endregion
                }
                return this.mUIAWAPButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIAWAPButton;

        #endregion
    }
}