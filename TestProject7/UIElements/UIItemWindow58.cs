namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow58 : WinWindow
    {
        public UIItemWindow58(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("TestProject7");

            #endregion
        }

        #region Properties

        public UIOurhighwayListItem UIOurhighwayListItem
        {
            get
            {
                if ((this.mUIOurhighwayListItem == null))
                {
                    this.mUIOurhighwayListItem = new UIOurhighwayListItem(this);
                }
                return this.mUIOurhighwayListItem;
            }
        }

        #endregion

        #region Fields

        private UIOurhighwayListItem mUIOurhighwayListItem;

        #endregion
    }
}