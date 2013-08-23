namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System;
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIInsurEcomSystemMaintWindow : BrowserWindow
    {
        public UIInsurEcomSystemMaintWindow()
        {
            #region Search Criteria

            this.SearchProperties[PropertyNames.Name] = "insurE-com System Maintenance";
            this.SearchProperties[PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("insurE-com System Maintenance");
            this.WindowTitles.Add("Blank Page");

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

        public UIInsurEcomSystemMaintTitleBar UIInsurEcomSystemMaintTitleBar
        {
            get
            {
                if ((this.mUIInsurEcomSystemMaintTitleBar == null))
                {
                    this.mUIInsurEcomSystemMaintTitleBar = new UIInsurEcomSystemMaintTitleBar(this);
                }
                return this.mUIInsurEcomSystemMaintTitleBar;
            }
        }

        public UIItemWindow59 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow59(this);
                }
                return this.mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private UILeftbarFrame mUILeftbarFrame;

        private UIContentFrame mUIContentFrame;

        private UIInsurEcomSystemMaintTitleBar mUIInsurEcomSystemMaintTitleBar;

        private UIItemWindow59 mUIItemWindow;

        #endregion
    }
}