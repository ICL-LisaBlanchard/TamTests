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

            this.SearchProperties[HtmlControl.PropertyNames.Id] = null;
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties[HtmlControl.PropertyNames.InnerText] = "Household Quotation For Covea Insurance ";
            this.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "border=0 width=\"95%\"";
            this.FilterProperties[PropertyNames.RowCount] = "102";
            this.FilterProperties[PropertyNames.ColumnCount] = "2";
            this.FilterProperties[HtmlControl.PropertyNames.Class] = null;
            this.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
            this.WindowTitles.Add("C:\\Users\\Lisa Blanchard\\AppData\\Local\\Temp\\HHQuote.htm");

            #endregion
        }

        #region Properties

        public HtmlCell UIItem26652Cell
        {
            get
            {
                if ((this.mUIItem26652Cell == null))
                {
                    this.mUIItem26652Cell = new HtmlCell(this);

                    #region Search Criteria

                    this.mUIItem26652Cell.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    this.mUIItem26652Cell.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    this.mUIItem26652Cell.SearchProperties[UITestControl.PropertyNames.MaxDepth] = "3";
                    this.mUIItem26652Cell.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "class=bodyText";
                    this.mUIItem26652Cell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "5";
                    this.mUIItem26652Cell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    this.mUIItem26652Cell.FilterProperties[HtmlControl.PropertyNames.Class] = "bodyText";
                    this.mUIItem26652Cell.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "10";

                    #endregion
                }
                return this.mUIItem26652Cell;
            }
        }

        public HtmlCell UIMrTestTestCell
        {
            get
            {
                if ((this.mUIMrTestTestCell == null))
                {
                    this.mUIMrTestTestCell = new HtmlCell(this);

                    #region Search Criteria

                    this.mUIMrTestTestCell.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    this.mUIMrTestTestCell.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    this.mUIMrTestTestCell.SearchProperties[UITestControl.PropertyNames.MaxDepth] = "3";
                    this.mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = null;
                    this.mUIMrTestTestCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "7";
                    this.mUIMrTestTestCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    this.mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    this.mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "14";

                    #endregion
                }
                return this.mUIMrTestTestCell;
            }
        }

        #endregion

        #region Fields

        private HtmlCell mUIItem26652Cell;

        private HtmlCell mUIMrTestTestCell;

        #endregion
    }
}