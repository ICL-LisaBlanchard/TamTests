namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public class UIItemTable : HtmlTable
    {
        public UIItemTable(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[HtmlControl.PropertyNames.Id] = null;
            SearchProperties[UITestControl.PropertyNames.Name] = null;
            FilterProperties[HtmlControl.PropertyNames.InnerText] = "Quote ID:949B625E-41E8-DB84-9983-0E83C10";
            FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = null;
            FilterProperties[PropertyNames.RowCount] = "29";
            FilterProperties[PropertyNames.ColumnCount] = "2";
            FilterProperties[HtmlControl.PropertyNames.Class] = null;
            FilterProperties[HtmlControl.PropertyNames.TagInstance] = "2";
            WindowTitles.Add("View Quote Details");

            #endregion
        }

        #region Properties

        public HtmlCell UIFORDFIESTABLACK16V13Cell
        {
            get
            {
                if ((mUIFORDFIESTABLACK16V13Cell == null))
                {
                    mUIFORDFIESTABLACK16V13Cell = new HtmlCell(this);

                    #region Search Criteria

                    mUIFORDFIESTABLACK16V13Cell.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    mUIFORDFIESTABLACK16V13Cell.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    mUIFORDFIESTABLACK16V13Cell.SearchProperties[UITestControl.PropertyNames.MaxDepth] = "3";
                    mUIFORDFIESTABLACK16V13Cell.FilterProperties[HtmlControl.PropertyNames.InnerText] = "FORD FIESTA BLACK 16V (1388cc) 2003-2003";
                    mUIFORDFIESTABLACK16V13Cell.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = null;
                    mUIFORDFIESTABLACK16V13Cell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "7";
                    mUIFORDFIESTABLACK16V13Cell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    mUIFORDFIESTABLACK16V13Cell.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUIFORDFIESTABLACK16V13Cell.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "16";
                    mUIFORDFIESTABLACK16V13Cell.WindowTitles.Add("View Quote Details");

                    #endregion
                }
                return mUIFORDFIESTABLACK16V13Cell;
            }
        }

        #endregion

        #region Fields

        private HtmlCell mUIFORDFIESTABLACK16V13Cell;

        #endregion
    }
}