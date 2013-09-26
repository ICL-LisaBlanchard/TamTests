namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIFindandGotoWindow : WinWindow
    {
        public UIFindandGotoWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Find and Goto";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "bosa_sdm_Microsoft Office WordView 11.0";
            WindowTitles.Add("Find and Goto");

            #endregion
        }

        #region Properties

        public UIDialog UIFindandGotoDialog
        {
            get
            {
                if ((mUIFindandGotoDialog == null))
                {
                    mUIFindandGotoDialog = new UIDialog(this, "Find and Goto", "Dialog");
                }
                return mUIFindandGotoDialog;
            }
        }

        #endregion

        #region Fields

        private UIDialog mUIFindandGotoDialog;

        #endregion
    }
}