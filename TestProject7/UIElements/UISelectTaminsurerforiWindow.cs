namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UISelectTaminsurerforiWindow : WinWindow
    {
        private const string WindowName = "Select Tam insurer for insurer code ";

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, className: "TListView");
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
                    mUIItemWindow1 = new UIItemWindow(this, className: "TPanel");
                }
                return mUIItemWindow1;
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

            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Select Tam insurer for insurer code ", PropertyExpressionOperator.Contains));
            SearchProperties[UITestControl.PropertyNames.ClassName] = "TfSelectItem";
            WindowTitles.Add(WindowName);

            #endregion
        }
    }
}