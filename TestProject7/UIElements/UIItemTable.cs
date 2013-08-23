namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemTable : HtmlTable
    {
        public UIItemTable(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[HtmlControl.PropertyNames.Id] = null;
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties[HtmlControl.PropertyNames.InnerText] = "Quote ID:949B625E-41E8-DB84-9983-0E83C10";
            this.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = null;
            this.FilterProperties[PropertyNames.RowCount] = "29";
            this.FilterProperties[PropertyNames.ColumnCount] = "2";
            this.FilterProperties[HtmlControl.PropertyNames.Class] = null;
            this.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "2";
            this.WindowTitles.Add("View Quote Details");

            #endregion
        }

        #region Properties

        public HtmlCell UIFORDFIESTABLACK16V13Cell
        {
            get
            {
                if ((this.mUIFORDFIESTABLACK16V13Cell == null))
                {
                    this.mUIFORDFIESTABLACK16V13Cell = new HtmlCell(this);

                    #region Search Criteria

                    this.mUIFORDFIESTABLACK16V13Cell.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    this.mUIFORDFIESTABLACK16V13Cell.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    this.mUIFORDFIESTABLACK16V13Cell.SearchProperties[UITestControl.PropertyNames.MaxDepth] = "3";
                    this.mUIFORDFIESTABLACK16V13Cell.FilterProperties[HtmlControl.PropertyNames.InnerText] = "FORD FIESTA BLACK 16V (1388cc) 2003-2003";
                    this.mUIFORDFIESTABLACK16V13Cell.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = null;
                    this.mUIFORDFIESTABLACK16V13Cell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "7";
                    this.mUIFORDFIESTABLACK16V13Cell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    this.mUIFORDFIESTABLACK16V13Cell.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    this.mUIFORDFIESTABLACK16V13Cell.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "16";
                    this.mUIFORDFIESTABLACK16V13Cell.WindowTitles.Add("View Quote Details");

                    #endregion
                }
                return this.mUIFORDFIESTABLACK16V13Cell;
            }
        }

        #endregion

        #region Fields

        private HtmlCell mUIFORDFIESTABLACK16V13Cell;

        #endregion
    }
}