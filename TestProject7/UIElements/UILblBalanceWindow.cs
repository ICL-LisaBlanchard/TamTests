namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UILblBalanceWindow : WinWindow
    {
        public UILblBalanceWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlName] = "lblBalance";
            this.WindowTitles.Add("Transaction List");

            #endregion
        }

        #region Properties

        public WinEdit UILblBalanceEdit
        {
            get
            {
                if ((this.mUILblBalanceEdit == null))
                {
                    this.mUILblBalanceEdit = new WinEdit(this);

                    #region Search Criteria

                    this.mUILblBalanceEdit.WindowTitles.Add("Transaction List");

                    #endregion
                }
                return this.mUILblBalanceEdit;
            }
        }

        #endregion

        #region Fields

        private WinEdit mUILblBalanceEdit;

        #endregion
    }
}