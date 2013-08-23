namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITransactiontoinsertWindow : WinWindow
    {
        public UITransactiontoinsertWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Transaction to insert";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TfSelectItem";
            this.WindowTitles.Add("Transaction to insert");

            #endregion
        }

        #region Properties

        public UIItemWindow26 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow26(this);
                }
                return this.mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow26 mUIItemWindow;

        #endregion
    }
}