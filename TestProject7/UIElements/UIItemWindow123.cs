namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow123 : WinWindow
    {
        public UIItemWindow123(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TListBox";
            this.WindowTitles.Add("Please select WHO to follow up");

            #endregion
        }

        #region Properties

        public WinList UIItemList
        {
            get
            {
                if ((this.mUIItemList == null))
                {
                    this.mUIItemList = new WinList(this);

                    #region Search Criteria

                    this.mUIItemList.WindowTitles.Add("Please select WHO to follow up");

                    #endregion
                }
                return this.mUIItemList;
            }
        }

        #endregion

        #region Fields

        private WinList mUIItemList;

        #endregion
    }
}