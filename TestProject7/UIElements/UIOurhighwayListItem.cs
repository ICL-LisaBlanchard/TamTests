namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOurhighwayListItem : WinListItem
    {
        public UIOurhighwayListItem(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "ourhighway";
            this.WindowTitles.Add("TestProject7");

            #endregion
        }

        #region Properties

        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);

                    #region Search Criteria

                    this.mUINameEdit.SearchProperties[UITestControl.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("TestProject7");

                    #endregion
                }
                return this.mUINameEdit;
            }
        }

        #endregion

        #region Fields

        private WinEdit mUINameEdit;

        #endregion
    }
}