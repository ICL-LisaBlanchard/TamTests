namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRebrokeWindow1 : WinWindow
    {
        public UIRebrokeWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "30";
            this.WindowTitles.Add("AUTO230-1001");

            #endregion
        }

        #region Properties

        public WinButton UIRebrokeButton 
        {
            get
            {
                if ((this.mUIRebrokeButton == null))
                {
                    this.mUIRebrokeButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIRebrokeButton.SearchProperties[UITestControl.PropertyNames.Name] = "Rebroke...";
                    this.mUIRebrokeButton.WindowTitles.Add("AUTO230-1001");

                    #endregion
                }
                return this.mUIRebrokeButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIRebrokeButton;

        #endregion
    }
}