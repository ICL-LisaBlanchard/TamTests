namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public class UIItemTable1 : HtmlTable
    {
        public UIItemTable1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[HtmlControl.PropertyNames.Id] = null;
            SearchProperties[UITestControl.PropertyNames.Name] = null;
            FilterProperties[HtmlControl.PropertyNames.InnerText] = "\r\n\r\ninsurE-com Household Quotation For R";
            FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "border=0 width=\"95%\"";
            FilterProperties[PropertyNames.RowCount] = "104";
            FilterProperties[PropertyNames.ColumnCount] = "2";
            FilterProperties[HtmlControl.PropertyNames.Class] = null;
            FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
            WindowTitles.Add("View Quote Details");

            #endregion
        }

        #region Properties

        public HtmlCell UIItem1989Cell
        {
            get
            {
                if ((mUIItem1989Cell == null))
                {
                    mUIItem1989Cell = new HtmlCell(this);

                    #region Search Criteria

                    mUIItem1989Cell.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    mUIItem1989Cell.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    mUIItem1989Cell.SearchProperties[UITestControl.PropertyNames.MaxDepth] = "3";
                    mUIItem1989Cell.FilterProperties[HtmlControl.PropertyNames.InnerText] = "1989";
                    mUIItem1989Cell.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = null;
                    mUIItem1989Cell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "14";
                    mUIItem1989Cell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    mUIItem1989Cell.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUIItem1989Cell.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "28";
                    mUIItem1989Cell.WindowTitles.Add("View Quote Details");

                    #endregion
                }
                return mUIItem1989Cell;
            }
        }

        public HtmlCell UIMrTestTestCell
        {
            get
            {
                if ((mUIMrTestTestCell == null))
                {
                    mUIMrTestTestCell = new HtmlCell(this);

                    #region Search Criteria

                    mUIMrTestTestCell.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    mUIMrTestTestCell.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    mUIMrTestTestCell.SearchProperties[UITestControl.PropertyNames.MaxDepth] = "3";
                    mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.InnerText] = "Mr Test Test";
                    mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = null;
                    mUIMrTestTestCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "7";
                    mUIMrTestTestCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "14";
                    mUIMrTestTestCell.WindowTitles.Add("View Quote Details");

                    #endregion
                }
                return mUIMrTestTestCell;
            }
        }

        #endregion

        #region Fields

        private HtmlCell mUIItem1989Cell;

        private HtmlCell mUIMrTestTestCell;

        #endregion
    }
}