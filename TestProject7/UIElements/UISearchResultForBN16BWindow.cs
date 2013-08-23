namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UISearchResultForBN16BWindow : WinWindow
    {
        public UISearchResultForBN16BWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Search Result For BN1 6BN";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Search Result For BN1 6BN");

            #endregion
        }

        #region Properties

        public UIOKWindow26 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow26(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIOKWindow26 mUIOKWindow;

        #endregion
    }
}