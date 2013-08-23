namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow39 : WinWindow
    {
        public UIItemWindow39()
        {
            #region Search Criteria

            this.SearchProperties[PropertyNames.AccessibleName] = "Desktop";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32769";

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
                }
                return this.mUIItemClient;
            }
        }

        public WinCustom UIItemCustom
        {
            get
            {
                if ((this.mUIItemCustom == null))
                {
                    this.mUIItemCustom = new WinCustom(this);
                }
                return this.mUIItemCustom;
            }
        }

        #endregion

        #region Fields

        private WinClient mUIItemClient;

        private WinCustom mUIItemCustom;

        #endregion
    }
}