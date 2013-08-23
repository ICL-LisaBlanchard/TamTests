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

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Save the file as";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Save the file as");

            #endregion
        }

        #region Properties

        public UICancelWindow4 UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UICancelWindow4(this);
                }
                return this.mUICancelWindow;
            }
        }

        public UIItemWindow20 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow20(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UISaveWindow UISaveWindow
        {
            get
            {
                if ((this.mUISaveWindow == null))
                {
                    this.mUISaveWindow = new UISaveWindow(this);
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

        private UICancelWindow4 mUICancelWindow;

        private UIItemWindow20 mUIItemWindow;

        private UISaveWindow mUISaveWindow;

        private UIDetailsPanePane mUIDetailsPanePane;

        #endregion
    }
}