namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICustomerggggggggggggWindow : WinWindow
    {
        public UICustomerggggggggggggWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Customer: ggggg gggggggg";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            this.WindowTitles.Add("Customer: ggggg gggggggg");

            #endregion
        }

        #region Properties

        public UICUSTOMERSWindow2 UICUSTOMERSWindow
        {
            get
            {
                if ((this.mUICUSTOMERSWindow == null))
                {
                    this.mUICUSTOMERSWindow = new UICUSTOMERSWindow2(this);
                }
                return this.mUICUSTOMERSWindow;
            }
        }

        #endregion

        #region Fields

        private UICUSTOMERSWindow2 mUICUSTOMERSWindow;

        #endregion
    }
}