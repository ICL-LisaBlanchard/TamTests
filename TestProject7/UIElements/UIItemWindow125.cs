namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow125 : WinWindow
    {
        public UIItemWindow125(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "12298";
            this.WindowTitles.Add("Run");

            #endregion
        }

        #region Properties

        public WinComboBox UIOpenComboBox
        {
            get
            {
                if ((this.mUIOpenComboBox == null))
                {
                    this.mUIOpenComboBox = new WinComboBox(this);

                    #region Search Criteria

                    this.mUIOpenComboBox.SearchProperties[UITestControl.PropertyNames.Name] = "Open:";
                    this.mUIOpenComboBox.WindowTitles.Add("Run");

                    #endregion
                }
                return this.mUIOpenComboBox;
            }
        }

        #endregion

        #region Fields

        private WinComboBox mUIOpenComboBox;

        #endregion
    }
}