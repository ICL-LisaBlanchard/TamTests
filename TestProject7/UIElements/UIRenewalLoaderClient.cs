namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRenewalLoaderClient : WinClient
    {
        
        public UIRenewalLoaderClient(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Renewal Loader";
            this.WindowTitles.Add("Renewal Loader");
            #endregion
        }
        
        #region Properties
        public WinButton UIRunButton
        {
            get
            {
                if ((this.mUIRunButton == null))
                {
                    this.mUIRunButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIRunButton.SearchProperties[WinButton.PropertyNames.Name] = "Run";
                    this.mUIRunButton.WindowTitles.Add("Renewal Loader");
                    #endregion
                }
                return this.mUIRunButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIRunButton;
        #endregion
    }
}