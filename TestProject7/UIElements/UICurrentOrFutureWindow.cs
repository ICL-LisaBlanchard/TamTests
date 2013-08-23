namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICurrentOrFutureWindow : WinWindow
    {
        
        public UICurrentOrFutureWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Current Or Future";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "TfCurrentOrFuture";
            this.WindowTitles.Add("Current Or Future");
            #endregion
        }
        
        #region Properties
        public UICurrentOrFutureClient UICurrentOrFutureClient
        {
            get
            {
                if ((this.mUICurrentOrFutureClient == null))
                {
                    this.mUICurrentOrFutureClient = new UICurrentOrFutureClient(this);
                }
                return this.mUICurrentOrFutureClient;
            }
        }
        #endregion
        
        #region Fields
        private UICurrentOrFutureClient mUICurrentOrFutureClient;
        #endregion
    }
}