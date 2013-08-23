namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow60 : WinWindow
    {
        public UIItemWindow60(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "1001";
            this.WindowTitles.Add("Run");

            #endregion
        }

        #region Properties

        public WinEdit UIOpenEdit
        {
            get
            {
                if ((this.mUIOpenEdit == null))
                {
                    this.mUIOpenEdit = new WinEdit(this);

                    #region Search Criteria

                    this.mUIOpenEdit.SearchProperties[UITestControl.PropertyNames.Name] = "Open:";
                    this.mUIOpenEdit.WindowTitles.Add("Run");

                    #endregion
                }
                return this.mUIOpenEdit;
            }
        }

        #endregion

        #region Fields

        private WinEdit mUIOpenEdit;

        #endregion
    }
}