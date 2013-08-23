namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System;
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBlankPageMicrosoftInWindow : BrowserWindow
    {
        public UIBlankPageMicrosoftInWindow()
        {
            #region Search Criteria

            this.SearchProperties[PropertyNames.ClassName] = "IEFrame";

            #endregion
        }

        public void LaunchUrl(Uri url)
        {
            this.CopyFrom(Launch(url));
        }

        #region Properties

        public UIBlankPageWindowsInteTitleBar UIBlankPageWindowsInteTitleBar
        {
            get
            {
                if ((this.mUIBlankPageWindowsInteTitleBar == null))
                {
                    this.mUIBlankPageWindowsInteTitleBar = new UIBlankPageWindowsInteTitleBar(this);
                }
                return this.mUIBlankPageWindowsInteTitleBar;
            }
        }

        #endregion

        #region Fields

        private UIBlankPageWindowsInteTitleBar mUIBlankPageWindowsInteTitleBar;

        #endregion
    }
}