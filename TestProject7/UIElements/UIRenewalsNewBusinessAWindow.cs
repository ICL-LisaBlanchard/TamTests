namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRenewalsNewBusinessAWindow : WinWindow
    {
        public UIRenewalsNewBusinessAWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Renewals : New Business Accept";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Renewals : New Business Accept");

            #endregion
        }

        #region Properties

        public UIItemWindow70 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow70(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIAcceptWindow2 UIAcceptWindow
        {
            get
            {
                if ((this.mUIAcceptWindow == null))
                {
                    this.mUIAcceptWindow = new UIAcceptWindow2(this);
                }
                return this.mUIAcceptWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow70 mUIItemWindow;

        private UIAcceptWindow2 mUIAcceptWindow;

        #endregion
    }
}