namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow66 : WinWindow
    {
        public UIItemWindow66(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "17";
            this.WindowTitles.Add("AUTO187-1001");

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

                    this.mUIItemEdit.WindowTitles.Add("AUTO187-1001");

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