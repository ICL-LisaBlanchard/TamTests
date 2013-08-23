namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow67 : WinWindow
    {
        public UIItemWindow67(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "msvb_lib_header";
            this.SearchProperties[UITestControl.PropertyNames.Instance] = "8";
            this.WindowTitles.Add("Rebroke Results Screen");

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

                    this.mUIItemClient.WindowTitles.Add("Rebroke Results Screen");

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