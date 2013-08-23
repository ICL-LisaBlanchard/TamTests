namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemTable1 : HtmlTable
    {
        public UIItemTable1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[HtmlControl.PropertyNames.Id] = null;
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties[HtmlControl.PropertyNames.InnerText] = "\r\n\r\ninsurE-com Household Quotation For R";
            this.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "border=0 width=\"95%\"";
            this.FilterProperties[PropertyNames.RowCount] = "104";
            this.FilterProperties[PropertyNames.ColumnCount] = "2";
            this.FilterProperties[HtmlControl.PropertyNames.Class] = null;
            this.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
            this.WindowTitles.Add("View Quote Details");

            #endregion
        }

        #region Properties

        public HtmlCell UIItem1989Cell
        {
            get
            {
                if ((this.mUIItem1989Cell == null))
                {
                    this.mUIItem1989Cell = new HtmlCell(this);

                    #region Search Criteria

                    this.mUIItem1989Cell.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    this.mUIItem1989Cell.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    this.mUIItem1989Cell.SearchProperties[UITestControl.PropertyNames.MaxDepth] = "3";
                    this.mUIItem1989Cell.FilterProperties[HtmlControl.PropertyNames.InnerText] = "1989";
                    this.mUIItem1989Cell.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = null;
                    this.mUIItem1989Cell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "14";
                    this.mUIItem1989Cell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    this.mUIItem1989Cell.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    this.mUIItem1989Cell.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "28";
                    this.mUIItem1989Cell.WindowTitles.Add("View Quote Details");

                    #endregion
                }
                return this.mUIItem1989Cell;
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
                    this.mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.InnerText] = "Mr Test Test";
                    this.mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = null;
                    this.mUIMrTestTestCell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "7";
                    this.mUIMrTestTestCell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    this.mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    this.mUIMrTestTestCell.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "14";
                    this.mUIMrTestTestCell.WindowTitles.Add("View Quote Details");

                    #endregion
                }
                return this.mUIMrTestTestCell;
            }
        }

        #endregion

        #region Fields

        private HtmlCell mUIItem1989Cell;

        private HtmlCell mUIMrTestTestCell;

        #endregion
    }
}