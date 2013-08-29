namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICreditCheckAtRenewalWindow : WinWindow
    {
        public UICreditCheckAtRenewalWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Credit Check At Renewal";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Credit Check At Renewal");

            #endregion
        }

        #region Properties

        public UIItemWindow UIProceedWindow
        {
            get
            {
                if ((this.mUIProceedWindow == null))
                {
                    this.mUIProceedWindow = new UIItemWindow(this, "1");
                }
                return this.mUIProceedWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIProceedWindow;

        #endregion
    }
}