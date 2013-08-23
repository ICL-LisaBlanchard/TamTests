namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow47 : WinWindow
    {
        public UIItemWindow47(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("Accept With Another Product");

            #endregion
        }

        #region Properties

        public WinComboBox UIItemComboBox
        {
            get
            {
                if ((this.mUIItemComboBox == null))
                {
                    this.mUIItemComboBox = new WinComboBox(this);

                    #region Search Criteria

                    this.mUIItemComboBox.WindowTitles.Add("Accept With Another Product");

                    #endregion
                }
                return this.mUIItemComboBox;
            }
        }

        #endregion

        #region Fields

        private WinComboBox mUIItemComboBox;

        #endregion
    }
}