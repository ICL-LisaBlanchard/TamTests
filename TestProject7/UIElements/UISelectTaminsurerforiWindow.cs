namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UISelectTaminsurerforiWindow : WinWindow
    {
        public UISelectTaminsurerforiWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Select Tam insurer for insurer code ";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TfSelectItem";
            this.WindowTitles.Add("Select Tam insurer for insurer code ");

            #endregion
        }

        #region Properties

        public UIItemWindow28 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow28(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow110 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow110(this);
                }
                return this.mUIItemWindow1;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow28 mUIItemWindow;

        private UIItemWindow110 mUIItemWindow1;

        #endregion
    }
}