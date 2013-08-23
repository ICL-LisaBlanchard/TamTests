namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIQuoteSelectListWindow : WinWindow
    {
        public UIQuoteSelectListWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Quote Select List";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Quote Select List");

            #endregion
        }

        #region Properties

        public UICancelWindow8 UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UICancelWindow8(this);
                }
                return this.mUICancelWindow;
            }
        }

        #endregion

        #region Fields

        private UICancelWindow8 mUICancelWindow;

        #endregion
    }
}