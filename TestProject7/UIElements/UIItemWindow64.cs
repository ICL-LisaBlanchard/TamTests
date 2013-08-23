namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow64 : WinWindow
    {
        public UIItemWindow64(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ListView20WndClass";
            this.WindowTitles.Add("Customer: ggggg gggggggg");

            #endregion
        }

        #region Properties

        public WinClient UICUSTOMERSClient
        {
            get
            {
                if ((this.mUICUSTOMERSClient == null))
                {
                    this.mUICUSTOMERSClient = new WinClient(this);

                    #region Search Criteria

                    this.mUICUSTOMERSClient.WindowTitles.Add("Customer: ggggg gggggggg");

                    #endregion
                }
                return this.mUICUSTOMERSClient;
            }
        }

        #endregion

        #region Fields

        private WinClient mUICUSTOMERSClient;

        #endregion
    }
}