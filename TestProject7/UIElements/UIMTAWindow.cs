namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIMTAWindow : WinWindow
    {
        public UIMTAWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "48";
            this.WindowTitles.Add("insur-E.tam");

            #endregion
        }

        #region Properties

        public WinButton UIMTAButton
        {
            get
            {
                if ((this.mUIMTAButton == null))
                {
                    this.mUIMTAButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIMTAButton.SearchProperties[UITestControl.PropertyNames.Name] = "MTA...";
                    this.mUIMTAButton.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUIMTAButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIMTAButton;

        #endregion
    }
}