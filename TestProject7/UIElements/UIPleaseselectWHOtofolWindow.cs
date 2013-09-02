namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPleaseSelectWhoToFolWindow : WinWindow
    {
        public UIPleaseSelectWhoToFolWindow()
        {
            #region Search Criteria

            this.windowName = "Please select WHO to follow up";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowName;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TfSelectItem";
            this.WindowTitles.Add(this.windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, className: "TPanel");
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
                    this.mUIItemWindow1 = new UIItemWindow(this, className: "TListBox");
                }
                return this.mUIItemWindow1;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIItemWindow1;

        #endregion
    }
}