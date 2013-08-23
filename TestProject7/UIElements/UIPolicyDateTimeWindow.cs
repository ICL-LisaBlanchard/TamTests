namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPolicyDateTimeWindow : WinWindow
    {
        public UIPolicyDateTimeWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Policy Date / Time";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Policy Date / Time");

            #endregion
        }

        #region Properties

        public UIConfirmWindow UIConfirmWindow
        {
            get
            {
                if ((this.mUIConfirmWindow == null))
                {
                    this.mUIConfirmWindow = new UIConfirmWindow(this);
                }
                return this.mUIConfirmWindow;
            }
        }

        #endregion

        #region Fields

        private UIConfirmWindow mUIConfirmWindow;

        #endregion
    }
}