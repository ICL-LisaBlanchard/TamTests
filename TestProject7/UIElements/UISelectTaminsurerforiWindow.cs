namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UISelectTaminsurerforiWindow : WinWindow
    {
        private const string WindowName = "Select Tam insurer for insurer code ";

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, className: "TListView");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow(this, className: "TPanel");
                }
                return this.mUIItemWindow1;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIItemWindow1;

        #endregion

        public UISelectTaminsurerforiWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Select Tam insurer for insurer code ";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TfSelectItem";
            this.WindowTitles.Add(WindowName);

            #endregion
        }
    }
}