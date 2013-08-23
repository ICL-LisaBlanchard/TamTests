namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPremiumWindow : WinWindow
    {
        public UIPremiumWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "15";
            this.WindowTitles.Add("Quote Results");

            #endregion
        }

        #region Properties

        public WinButton UIPremiumButton
        {
            get
            {
                if ((this.mUIPremiumButton == null))
                {
                    this.mUIPremiumButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIPremiumButton.SearchProperties[UITestControl.PropertyNames.Name] = "Premium";
                    this.mUIPremiumButton.WindowTitles.Add("Quote Results");

                    #endregion
                }
                return this.mUIPremiumButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIPremiumButton;

        #endregion
    }
}