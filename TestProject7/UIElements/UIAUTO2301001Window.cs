namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIAUTO2301001Window : WinWindow
    {
        public UIAUTO2301001Window()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "AUTO230-1001";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("AUTO230-1001");

            #endregion
        }

        #region Properties

        public UIItemWindow UIRebrokeWindow
        {
            get
            {
                if ((this.mUIRebrokeWindow == null))
                {
                    this.mUIRebrokeWindow = new UIItemWindow(this, "30");
                }
                return this.mUIRebrokeWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIRebrokeWindow;

        #endregion
    }
}