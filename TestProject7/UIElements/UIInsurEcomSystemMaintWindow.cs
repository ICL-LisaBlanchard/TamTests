namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;

    public class UIInsurEcomSystemMaintWindow : BrowserWindow
    {
        public UIInsurEcomSystemMaintWindow()
        {
            #region Search Criteria

            windowName1 = "insurE-com System Maintenance";
            SearchProperties[PropertyNames.Name] = windowName1;
            SearchProperties[PropertyNames.ClassName] = "IEFrame";
            WindowTitles.Add(windowName1);
            windowName2 = "Blank Page";
            WindowTitles.Add(windowName2);

            #endregion
        }

        public void LaunchUrl(Uri url)
        {
            CopyFrom(Launch(url));
        }

        #region Properties

        public UILeftbarFrame UILeftbarFrame
        {
            get
            {
                if ((mUILeftbarFrame == null))
                {
                    mUILeftbarFrame = new UILeftbarFrame(this);
                }
                return mUILeftbarFrame;
            }
        }

        public UIContentFrame UIContentFrame
        {
            get
            {
                if ((mUIContentFrame == null))
                {
                    mUIContentFrame = new UIContentFrame(this);
                }
                return mUIContentFrame;
            }
        }

        public UITitleBar UIInsurEcomSystemMaintTitleBar
        {
            get
            {
                if ((mUIInsurEcomSystemMaintTitleBar == null))
                {
                    mUIInsurEcomSystemMaintTitleBar = new UITitleBar(this);
                }
                return mUIInsurEcomSystemMaintTitleBar;
            }
        }

        public UITestControl UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "41477");
                }
                return mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName1;

        private readonly string windowName2;

        private UILeftbarFrame mUILeftbarFrame;

        private UIContentFrame mUIContentFrame;

        private UITitleBar mUIInsurEcomSystemMaintTitleBar;

        private UITestControl mUIItemWindow;

        #endregion
    }
}