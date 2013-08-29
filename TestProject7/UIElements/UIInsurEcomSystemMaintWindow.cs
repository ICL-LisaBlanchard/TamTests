namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System;
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIInsurEcomSystemMaintWindow : BrowserWindow
    {
        public UIInsurEcomSystemMaintWindow()
        {
            #region Search Criteria

            this.windowName1 = "insurE-com System Maintenance";
            this.SearchProperties[PropertyNames.Name] = this.windowName1;
            this.SearchProperties[PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add(this.windowName1);
            this.windowName2 = "Blank Page";
            this.WindowTitles.Add(this.windowName2);

            #endregion
        }

        public void LaunchUrl(Uri url)
        {
            this.CopyFrom(Launch(url));
        }

        #region Properties

        public UILeftbarFrame UILeftbarFrame
        {
            get
            {
                if ((this.mUILeftbarFrame == null))
                {
                    this.mUILeftbarFrame = new UILeftbarFrame(this);
                }
                return this.mUILeftbarFrame;
            }
        }

        public UIContentFrame UIContentFrame
        {
            get
            {
                if ((this.mUIContentFrame == null))
                {
                    this.mUIContentFrame = new UIContentFrame(this);
                }
                return this.mUIContentFrame;
            }
        }

        public UITitleBar UIInsurEcomSystemMaintTitleBar
        {
            get
            {
                if ((this.mUIInsurEcomSystemMaintTitleBar == null))
                {
                    this.mUIInsurEcomSystemMaintTitleBar = new UITitleBar(this);
                }
                return this.mUIInsurEcomSystemMaintTitleBar;
            }
        }

        public UITestControl UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "41477");
                }
                return this.mUIItemWindow;
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