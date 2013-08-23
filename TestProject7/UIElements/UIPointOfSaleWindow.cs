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

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Point Of Sale";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Point Of Sale");

            #endregion
        }

        #region Properties

        public UIDeferPrintingWindow UIDeferPrintingWindow
        {
            get
            {
                if ((this.mUIDeferPrintingWindow == null))
                {
                    this.mUIDeferPrintingWindow = new UIDeferPrintingWindow(this);
                }
                return this.mUIDeferPrintingWindow;
            }
        }

        public UIOKWindow16 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow16(this);
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

                    this.mUIPointOfSaleClient.SearchProperties[UITestControl.PropertyNames.Name] = "Point Of Sale";
                    this.mUIPointOfSaleClient.WindowTitles.Add("Point Of Sale");

                    #endregion
                }
                return this.mUIPointOfSaleClient;
            }
        }

        #endregion

        #region Fields

        private UIDeferPrintingWindow mUIDeferPrintingWindow;

        private UIOKWindow16 mUIOKWindow;

        private WinClient mUIPointOfSaleClient;

        #endregion
    }
}