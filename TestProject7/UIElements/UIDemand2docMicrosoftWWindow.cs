namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIDemand2DocMicrosoftWWindow : WinWindow

    {
        public UIDemand2DocMicrosoftWWindow()
        {
            #region Search Criteria

            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, " - Microsoft Word Viewer", PropertyExpressionOperator.Contains));
            SearchProperties[UITestControl.PropertyNames.ClassName] = "OpusApp";

            #endregion
        }

        #region Properties

        public UIApplicationMenuBar UIMenuBarMenuBar
        {
            get
            {
                if ((mUIMenuBarMenuBar == null))
                {
                    mUIMenuBarMenuBar = new UIApplicationMenuBar(this, "Menu Bar");
                }
                return mUIMenuBarMenuBar;
            }
        }

        public UITitleBar UIDemand2DocMicrosoftWTitleBar
        {
            get
            {
                if ((mUIDemand2DocMicrosoftWTitleBar == null))
                {
                    mUIDemand2DocMicrosoftWTitleBar = new UITitleBar(this);
                }
                return mUIDemand2DocMicrosoftWTitleBar;
            }
        }

        #endregion

        #region Fields

        private UIApplicationMenuBar mUIMenuBarMenuBar;

        private UITitleBar mUIDemand2DocMicrosoftWTitleBar;

        #endregion
    }
}