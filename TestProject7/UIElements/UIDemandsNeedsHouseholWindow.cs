namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDemandsNeedsHouseholWindow : WinWindow
    {
        public UIDemandsNeedsHouseholWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Demands&Needs(HouseholdBuildings&Contents) [Compatibility Mode] - Microsoft Word";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "OpusApp";
            this.WindowTitles.Add("Demands&Needs(HouseholdBuildings&Contents) [Compatibility Mode] - Microsoft Word");

            #endregion
        }

        #region Properties

        public WinClient UIDemandsNeedsHouseholClient
        {
            get
            {
                if ((this.mUIDemandsNeedsHouseholClient == null))
                {
                    this.mUIDemandsNeedsHouseholClient = new WinClient(this);

                    #region Search Criteria

                    this.mUIDemandsNeedsHouseholClient.SearchProperties[UITestControl.PropertyNames.Name] =
                        "DemandsNeeds(HouseholdBuildings&Contents) [Compatibility Mode] - Microsoft Word";
                    this.mUIDemandsNeedsHouseholClient.WindowTitles.Add("Demands&Needs(HouseholdBuildings&Contents) [Compatibility Mode] - Microsoft Word");

                    #endregion
                }
                return this.mUIDemandsNeedsHouseholClient;
            }
        }

        public UIItemWindow46 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow46(this);
                }
                return this.mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private WinClient mUIDemandsNeedsHouseholClient;

        private UIItemWindow46 mUIItemWindow;

        #endregion
    }
}