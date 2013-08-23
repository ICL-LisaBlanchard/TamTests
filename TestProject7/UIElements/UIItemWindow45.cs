namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow45 : WinWindow
    {
        public UIItemWindow45(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TChatEntryControl";
            this.WindowTitles.Add("KV31");

            #endregion
        }

        #region Properties

        public UIKV31Client UIKV31Client
        {
            get
            {
                if ((this.mUIKV31Client == null))
                {
                    this.mUIKV31Client = new UIKV31Client(this);
                }
                return this.mUIKV31Client;
            }
        }

        #endregion

        #region Fields

        private UIKV31Client mUIKV31Client;

        #endregion
    }
}