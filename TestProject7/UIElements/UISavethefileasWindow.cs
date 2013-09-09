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

            this.windowName = "Save the file as";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowName;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add(this.windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UIItemWindow(this, controlId: "2");
                }
                return this.mUICancelWindow;
            }
        }

        public UITestControl UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "1001");
                }
                return this.mUIItemWindow;
            }
        }

        public UITestControl UISaveWindow
        {
            get
            {
                if ((this.mUISaveWindow == null))
                {
                    this.mUISaveWindow = new UIItemWindow(this, controlId: "1");
                }
                return this.mUISaveWindow;
            }
        }

        public UIDetailsPanePane UIDetailsPanePane
        {
            get
            {
                if ((this.mUIDetailsPanePane == null))
                {
                    this.mUIDetailsPanePane = new UIDetailsPanePane(this);
                }
                return this.mUIDetailsPanePane;
            }
        }

        public WinTitleBar UISavethefileasTitleBar
        {
            get
            {
                if ((this.mUISavethefileasTitleBar == null))
                {
                    this.mUISavethefileasTitleBar = new WinTitleBar(this);

                    #region Search Criteria

                    this.mUISavethefileasTitleBar.WindowTitles.Add("Save the file as");

                    #endregion
                }
                return this.mUISavethefileasTitleBar;
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