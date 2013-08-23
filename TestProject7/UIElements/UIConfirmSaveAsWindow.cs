namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIConfirmSaveAsWindow : WinWindow
    {
        public UIConfirmSaveAsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Confirm Save As";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Confirm Save As");

            #endregion
        }

        #region Properties

        public UIConfirmSaveAsPane UIConfirmSaveAsPane
        {
            get
            {
                if ((this.mUIConfirmSaveAsPane == null))
                {
                    this.mUIConfirmSaveAsPane = new UIConfirmSaveAsPane(this);
                }
                return this.mUIConfirmSaveAsPane;
            }
        }

        public UIConfirmSaveAsDialog UIConfirmSaveAsDialog
        {
            get
            {
                if ((this.mUIConfirmSaveAsDialog == null))
                {
                    this.mUIConfirmSaveAsDialog = new UIConfirmSaveAsDialog(this);
                }
                return this.mUIConfirmSaveAsDialog;
            }
        }

        #endregion

        #region Fields

        private UIConfirmSaveAsPane mUIConfirmSaveAsPane;

        private UIConfirmSaveAsDialog mUIConfirmSaveAsDialog;

        #endregion
    }
}