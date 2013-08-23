namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow70 : WinWindow
    {
        public UIItemWindow70(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ListView20WndClass";
            this.WindowTitles.Add("Renewals : New Business Accept");

            #endregion
        }

        #region Properties

        public WinClient UIItemClient
        {
            get
            {
                if ((this.mUIItemClient == null))
                {
                    this.mUIItemClient = new WinClient(this);

                    #region Search Criteria

                    this.mUIItemClient.WindowTitles.Add("Renewals : New Business Accept");

                    #endregion
                }
                return this.mUIItemClient;
            }
        }

        #endregion

        #region Fields

        private WinClient mUIItemClient;

        #endregion
    }
}