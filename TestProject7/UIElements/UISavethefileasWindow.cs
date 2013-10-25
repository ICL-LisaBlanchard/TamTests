namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UISavethefileasWindow : WinWindow
    {
        public UISavethefileasWindow()
        {
            #region Search Criteria

            windowName = "Save";
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Save", PropertyExpressionOperator.Contains));
            WindowTitles.Add(windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((mUICancelWindow == null))
                {
                    mUICancelWindow = new UIItemWindow(this, controlId: "2");
                }
                return mUICancelWindow;
            }
        }

        public UITestControl UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "1001");
                }
                return mUIItemWindow;
            }
        }

        public UITestControl UISaveWindow
        {
            get
            {
                if ((mUISaveWindow == null))
                {
                    mUISaveWindow = new UIItemWindow(this, controlId: "1");
                }
                return mUISaveWindow;
            }
        }

        public UIDetailsPanePane UIDetailsPanePane
        {
            get
            {
                if ((mUIDetailsPanePane == null))
                {
                    mUIDetailsPanePane = new UIDetailsPanePane(this);
                }
                return mUIDetailsPanePane;
            }
        }

        public WinTitleBar UISavethefileasTitleBar
        {
            get
            {
                if ((mUISavethefileasTitleBar == null))
                {
                    mUISavethefileasTitleBar = new WinTitleBar(this);

                    #region Search Criteria

                    mUISavethefileasTitleBar.WindowTitles.Add("Save the file as");

                    #endregion
                }
                return mUISavethefileasTitleBar;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName;

        private UIItemWindow mUICancelWindow;

        private UITestControl mUIItemWindow;

        private UITestControl mUISaveWindow;

        private UIDetailsPanePane mUIDetailsPanePane;

        private WinTitleBar mUISavethefileasTitleBar;

        #endregion
    }
}