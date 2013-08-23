namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow20 : WinWindow
    {
        public UIItemWindow20(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "1001";
            this.WindowTitles.Add("Save the file as");

            #endregion
        }

        #region Properties

        public WinEdit UIFilenameEdit
        {
            get
            {
                if ((this.mUIFilenameEdit == null))
                {
                    this.mUIFilenameEdit = new WinEdit(this);

                    #region Search Criteria

                    this.mUIFilenameEdit.SearchProperties[UITestControl.PropertyNames.Name] = "File name:";
                    this.mUIFilenameEdit.WindowTitles.Add("Save the file as");

                    #endregion
                }
                return this.mUIFilenameEdit;
            }
        }

        #endregion

        #region Fields

        private WinEdit mUIFilenameEdit;

        #endregion
    }
}