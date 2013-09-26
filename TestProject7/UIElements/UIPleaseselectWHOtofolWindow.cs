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

            windowName = "Please select WHO to follow up";
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, windowName, PropertyExpressionOperator.Contains));
            SearchProperties[UITestControl.PropertyNames.Name] = windowName;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "TfSelectItem";
            WindowTitles.Add(windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, className: "TPanel");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((mUIItemWindow1 == null))
                {
                    mUIItemWindow1 = new UIItemWindow(this, className: "TListBox");
                }
                return mUIItemWindow1;
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