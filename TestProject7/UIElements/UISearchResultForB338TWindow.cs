namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UISearchResultForB338TWindow : WinWindow
    {
        
        public UISearchResultForB338TWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.Name, "Search Result For", PropertyExpressionOperator.Contains));
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6FormDC";
            #endregion
        }
        
        #region Properties
        public UIOKWindow9 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow9(this);
                }
                return this.mUIOKWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIOKWindow9 mUIOKWindow;
        #endregion
    }
}