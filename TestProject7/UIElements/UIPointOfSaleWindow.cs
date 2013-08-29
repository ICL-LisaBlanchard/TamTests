namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPointOfSaleWindow : WinWindow
    {
        public UIPointOfSaleWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowTitle;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIDeferPrintingWindow
        {
            get
            {
                if ((this.mUIDeferPrintingWindow == null))
                {
                    this.mUIDeferPrintingWindow = new UIItemWindow(this, controlId: "3");
                }
                return this.mUIDeferPrintingWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "6");
                }
                return this.mUIOKWindow;
            }
        }

        public WinClient UIPointOfSaleClient
        {
            get
            {
                if ((this.mUIPointOfSaleClient == null))
                {
                    this.mUIPointOfSaleClient = new WinClient(this);

                    #region Search Criteria

                    this.mUIPointOfSaleClient.SearchProperties[UITestControl.PropertyNames.Name] = this.windowTitle;
                    this.mUIPointOfSaleClient.WindowTitles.Add(this.windowTitle);

                    #endregion
                }
                return this.mUIPointOfSaleClient;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIDeferPrintingWindow;

        private UIItemWindow mUIOKWindow;

        private WinClient mUIPointOfSaleClient;

        private string windowTitle = "Point Of Sale";

        #endregion
    }
}