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

            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, " - Microsoft Word Viewer", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "OpusApp";

            #endregion
        }

        #region Properties

        public UIApplicationMenuBar UIMenuBarMenuBar
        {
            get
            {
                if ((this.mUIMenuBarMenuBar == null))
                {
                    this.mUIMenuBarMenuBar = new UIApplicationMenuBar(this, "Menu Bar");
                }
                return this.mUIMenuBarMenuBar;
            }
        }

        public UITitleBar UIDemand2DocMicrosoftWTitleBar
        {
            get
            {
                if ((this.mUIDemand2DocMicrosoftWTitleBar == null))
                {
                    this.mUIDemand2DocMicrosoftWTitleBar = new UITitleBar(this);
                }
                return this.mUIDemand2DocMicrosoftWTitleBar;
            }
        }

        #endregion

        #region Fields

        private UIApplicationMenuBar mUIMenuBarMenuBar;

        private UITitleBar mUIDemand2DocMicrosoftWTitleBar;

        #endregion
    }
}