namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDeferPrintingWindow : WinWindow
    {
        public UIDeferPrintingWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "3";
            this.WindowTitles.Add("Point Of Sale");

            #endregion
        }

        #region Properties

        public WinCheckBox UIDeferPrintingCheckBox
        {
            get
            {
                if ((this.mUIDeferPrintingCheckBox == null))
                {
                    this.mUIDeferPrintingCheckBox = new WinCheckBox(this);

                    #region Search Criteria

                    this.mUIDeferPrintingCheckBox.SearchProperties[UITestControl.PropertyNames.Name] = "Defer Printing?";
                    this.mUIDeferPrintingCheckBox.WindowTitles.Add("Point Of Sale");

                    #endregion
                }
                return this.mUIDeferPrintingCheckBox;
            }
        }

        #endregion

        #region Fields

        private WinCheckBox mUIDeferPrintingCheckBox;

        #endregion
    }
}