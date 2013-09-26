namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;

    public class UIBlankPageMicrosoftInWindow : BrowserWindow
    {
        public UIBlankPageMicrosoftInWindow()
        {
            #region Search Criteria

            SearchProperties[PropertyNames.ClassName] = "IEFrame";

            #endregion
        }

        public void LaunchUrl(Uri url)
        {
            CopyFrom(Launch(url));
        }

        #region Properties

        public UITitleBar UIBlankPageWindowsInteTitleBar
        {
            get
            {
                if ((mUIBlankPageWindowsInteTitleBar == null))
                {
                    mUIBlankPageWindowsInteTitleBar = new UITitleBar(this);
                }
                return mUIBlankPageWindowsInteTitleBar;
            }
        }

        #endregion

        #region Fields

        private UITitleBar mUIBlankPageWindowsInteTitleBar;

        #endregion
    }
}