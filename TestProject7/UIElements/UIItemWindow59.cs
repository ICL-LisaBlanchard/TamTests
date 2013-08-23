namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow59 : WinWindow
    {
        public UIItemWindow59(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "41477";
            this.WindowTitles.Add("Blank Page");

            #endregion
        }

        #region Properties

        public WinEdit UIAddressandsearchusinEdit
        {
            get
            {
                if ((this.mUIAddressandsearchusinEdit == null))
                {
                    this.mUIAddressandsearchusinEdit = new WinEdit(this);

                    #region Search Criteria

                    this.mUIAddressandsearchusinEdit.SearchProperties[UITestControl.PropertyNames.Name] = "Address and search using Bing";
                    this.mUIAddressandsearchusinEdit.WindowTitles.Add("Blank Page");

                    #endregion
                }
                return this.mUIAddressandsearchusinEdit;
            }
        }

        #endregion

        #region Fields

        private WinEdit mUIAddressandsearchusinEdit;

        #endregion
    }
}