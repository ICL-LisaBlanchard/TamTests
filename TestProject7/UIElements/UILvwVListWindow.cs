namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UILvwVListWindow : WinWindow
    {
        public UILvwVListWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlName] = "lvwVList";
            this.WindowTitles.Add("Transaction List");

            #endregion
        }

        #region Properties

        public WinList UILvwVListList
        {
            get
            {
                if ((this.mUILvwVListList == null))
                {
                    this.mUILvwVListList = new WinList(this);

                    #region Search Criteria

                    this.mUILvwVListList.SearchProperties[UITestControl.PropertyNames.Name] = "Enter Code";
                    this.mUILvwVListList.WindowTitles.Add("Transaction List");

                    #endregion
                }
                return this.mUILvwVListList;
            }
        }

        #endregion

        #region Fields

        private WinList mUILvwVListList;

        #endregion
    }
}