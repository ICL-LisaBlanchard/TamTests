namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIOpenWindow : WinWindow
    {
        public UIOpenWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Open";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Open");

            #endregion
        }

        #region Properties

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UIItemWindow(this, "2");
                }
                return this.mUICancelWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUICancelWindow;

        #endregion
    }
}