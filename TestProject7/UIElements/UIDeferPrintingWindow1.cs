namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDeferPrintingWindow1 : WinWindow
    {
        public UIDeferPrintingWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "4";
            this.WindowTitles.Add("Print Documents");

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
                    this.mUIDeferPrintingCheckBox.WindowTitles.Add("Print Documents");

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