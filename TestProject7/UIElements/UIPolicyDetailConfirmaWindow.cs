namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPolicyDetailConfirmaWindow : WinWindow
    {
        public UIPolicyDetailConfirmaWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Policy Detail Confirmation";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Policy Detail Confirmation");

            #endregion
        }

        #region Properties

        public UIItemWindow44 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow44(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UILookupWindow2 UILookupWindow
        {
            get
            {
                if ((this.mUILookupWindow == null))
                {
                    this.mUILookupWindow = new UILookupWindow2(this);
                }
                return this.mUILookupWindow;
            }
        }

        public UIConfirmWindow1 UIConfirmWindow
        {
            get
            {
                if ((this.mUIConfirmWindow == null))
                {
                    this.mUIConfirmWindow = new UIConfirmWindow1(this);
                }
                return this.mUIConfirmWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow44 mUIItemWindow;

        private UILookupWindow2 mUILookupWindow;

        private UIConfirmWindow1 mUIConfirmWindow;

        #endregion
    }
}