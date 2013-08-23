namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIProgramManagerWindow : WinWindow
    {
        public UIProgramManagerWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Program Manager";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "Progman";
            this.WindowTitles.Add("Program Manager");

            #endregion
        }

        #region Properties

        public UIDesktopList UIDesktopList
        {
            get
            {
                if ((this.mUIDesktopList == null))
                {
                    this.mUIDesktopList = new UIDesktopList(this);
                }
                return this.mUIDesktopList;
            }
        }

        public UIFolderViewWindow UIFolderViewWindow
        {
            get
            {
                if ((this.mUIFolderViewWindow == null))
                {
                    this.mUIFolderViewWindow = new UIFolderViewWindow(this);
                }
                return this.mUIFolderViewWindow;
            }
        }

        #endregion

        #region Fields

        private UIDesktopList mUIDesktopList;

        private UIFolderViewWindow mUIFolderViewWindow;

        #endregion
    }
}