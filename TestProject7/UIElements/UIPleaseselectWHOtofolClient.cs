namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPleaseselectWHOtofolClient : WinClient
    {
        public UIPleaseselectWHOtofolClient(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.WindowTitles.Add("Please select WHO to follow up");

            #endregion
        }

        #region Properties

        public WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIOKButton.SearchProperties[UITestControl.PropertyNames.Name] = "Ok";
                    this.mUIOKButton.WindowTitles.Add("Please select WHO to follow up");

                    #endregion
                }
                return this.mUIOKButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIOKButton;

        #endregion
    }
}