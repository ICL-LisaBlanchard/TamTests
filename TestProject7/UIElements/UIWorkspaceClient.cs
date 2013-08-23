namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIWorkspaceClient : WinClient
    {
        public UIWorkspaceClient(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Workspace";
            this.WindowTitles.Add("Policy: autotest");

            #endregion
        }

        #region Properties

        public WinWindow UIBillingScreenMOTOTESWindow
        {
            get
            {
                if ((this.mUIBillingScreenMOTOTESWindow == null))
                {
                    this.mUIBillingScreenMOTOTESWindow = new WinWindow(this);

                    #region Search Criteria

                    this.mUIBillingScreenMOTOTESWindow.SearchProperties[UITestControl.PropertyNames.Name] = "Billing Screen: MOTO-TESTPOLICYNUMBER";
                    this.mUIBillingScreenMOTOTESWindow.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
                    this.mUIBillingScreenMOTOTESWindow.WindowTitles.Add("Policy: autotest");

                    #endregion
                }
                return this.mUIBillingScreenMOTOTESWindow;
            }
        }

        #endregion

        #region Fields

        private WinWindow mUIBillingScreenMOTOTESWindow;

        #endregion
    }
}