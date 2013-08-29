namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICurrentOrFutureWindow : WinWindow
    {
        public UICurrentOrFutureWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Current Or Future";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TfCurrentOrFuture";
            this.WindowTitles.Add("Current Or Future");

            #endregion
        }

        #region Properties

        public UIClient UIClient
        {
            get
            {
                if ((this.mUICurrentOrFutureClient == null))
                {
                    this.mUICurrentOrFutureClient = new UIClient(this, "Current Or Future", "Current Or Future");
                }
                return this.mUICurrentOrFutureClient;
            }
        }

        #endregion

        #region Fields

        private UIClient mUICurrentOrFutureClient;

        #endregion
    }
}