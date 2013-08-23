namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow26 : WinWindow
    {
        public UIItemWindow26(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TPanel";
            this.WindowTitles.Add("Transaction to insert");

            #endregion
        }

        #region Properties

        public UITransactiontoinsertClient UITransactiontoinsertClient
        {
            get
            {
                if ((this.mUITransactiontoinsertClient == null))
                {
                    this.mUITransactiontoinsertClient = new UITransactiontoinsertClient(this);
                }
                return this.mUITransactiontoinsertClient;
            }
        }

        #endregion

        #region Fields

        private UITransactiontoinsertClient mUITransactiontoinsertClient;

        #endregion
    }
}