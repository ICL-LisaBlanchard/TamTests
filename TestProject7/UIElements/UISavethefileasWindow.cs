namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
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

        public UIItemWindow UIItemWindow
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

        public UIItemWindow UISaveWindow
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

        #endregion

        #region Fields

        private UIItemWindow mUICancelWindow;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUISaveWindow;

        private UIDetailsPanePane mUIDetailsPanePane;

        private readonly string windowName;

        #endregion
    }
}