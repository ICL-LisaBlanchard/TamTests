namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIImportOptionsClient : WinClient
    {
        public UIImportOptionsClient(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Import Options";
            this.WindowTitles.Add("Import to TAM");

            #endregion
        }

        #region Properties

        public WinCheckBox UIAddActivityCheckBox
        {
            get
            {
                if ((this.mUIAddActivityCheckBox == null))
                {
                    this.mUIAddActivityCheckBox = new WinCheckBox(this);

                    #region Search Criteria

                    this.mUIAddActivityCheckBox.SearchProperties[UITestControl.PropertyNames.Name] = "Add Activity";
                    this.mUIAddActivityCheckBox.WindowTitles.Add("Import to TAM");

                    #endregion
                }
                return this.mUIAddActivityCheckBox;
            }
        }

        #endregion

        #region Fields

        private WinCheckBox mUIAddActivityCheckBox;

        #endregion
    }
}