namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow110 : WinWindow
    {
        public UIItemWindow110(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TPanel";
            this.WindowTitles.Add("Select Tam insurer for insurer code ");

            #endregion
        }

        #region Properties

        public UISelectTaminsurerforiClient UISelectTaminsurerforiClient
        {
            get
            {
                if ((this.mUISelectTaminsurerforiClient == null))
                {
                    this.mUISelectTaminsurerforiClient = new UISelectTaminsurerforiClient(this);
                }
                return this.mUISelectTaminsurerforiClient;
            }
        }

        #endregion

        #region Fields

        private UISelectTaminsurerforiClient mUISelectTaminsurerforiClient;

        #endregion
    }
}