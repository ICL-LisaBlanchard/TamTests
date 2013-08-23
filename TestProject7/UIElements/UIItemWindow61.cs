namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow61 : WinWindow
    {
        public UIItemWindow61(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "7";
            this.SearchProperties[UITestControl.PropertyNames.Instance] = "2";
            this.WindowTitles.Add("insur-E.tam");

            #endregion
        }

        #region Properties

        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);

                    #region Search Criteria

                    this.mUIItemEdit.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUIItemEdit;
            }
        }

        #endregion

        #region Fields

        private WinEdit mUIItemEdit;

        #endregion
    }
}