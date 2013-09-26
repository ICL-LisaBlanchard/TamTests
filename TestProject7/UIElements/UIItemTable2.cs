namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public class UIItemTable2 : HtmlTable
    {
        public UIItemTable2(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[HtmlControl.PropertyNames.Id] = null;
            SearchProperties[UITestControl.PropertyNames.Name] = null;
            FilterProperties[HtmlControl.PropertyNames.InnerText] = "Household Quotation For Covea Insurance ";
            FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "border=0 width=\"95%\"";
            FilterProperties[PropertyNames.RowCount] = "102";
            FilterProperties[PropertyNames.ColumnCount] = "2";
            FilterProperties[HtmlControl.PropertyNames.Class] = null;
            FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
            WindowTitles.Add("C:\\Users\\Lisa Blanchard\\AppData\\Local\\Temp\\HHQuote.htm");

            #endregion
        }

        #region Properties

        public HtmlCell UIItem26652Cell
        {
            get
            {
                if ((mUIItem26652Cell == null))
                {
                    mUIItem26652Cell = new HtmlCell(this);

                    #region Search Criteria

                    mUIItem26652Cell.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    mUIItem26652Cell.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    mUIItem26652Cell.SearchProperties[UITestControl.PropertyNames.MaxDepth] = "3";
                    mUIItem26652Cell.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "class=bodyText";
                    mUIItem26652Cell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "5";
                    mUIItem26652Cell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    mUIItem26652Cell.FilterProperties[HtmlControl.PropertyNames.Class] = "bodyText";
                    mUIItem26652Cell.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "10";

                    #endregion
                }
                return mUIItem26652Cell;
            }
        }

        public HtmlCell UIItem181873Cell
        {
            get
            {
                if ((mUIItem181873Cell == null))
                {
                    mUIItem181873Cell = new HtmlCell(this);

                    #region Search Criteria

                    mUIItem181873Cell.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    mUIItem181873Cell.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    mUIItem181873Cell.SearchProperties[UITestControl.PropertyNames.MaxDepth] = "3";
                    mUIItem181873Cell.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = null;
                    mUIItem181873Cell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "2";
                    mUIItem181873Cell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    mUIItem181873Cell.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUIItem181873Cell.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "9";

                    #endregion
                }
                return mUIItem181873Cell;
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
                    mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = null;
                    mUIMrTestTestCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "7";
                    mUIMrTestTestCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "14";

                    #endregion
                }
                return mUIMrTestTestCell;
            }
        }

        #endregion

        #region Fields

        private HtmlCell mUIItem26652Cell;

        private HtmlCell mUIItem181873Cell;

        private HtmlCell mUIMrTestTestCell;

        #endregion
    }
}