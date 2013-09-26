namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIAUTO2251001Window : WinWindow
    {
        public UIAUTO2251001Window()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "AUTO225-1001";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("AUTO225-1001");

            #endregion
        }

        #region Properties

        public UIItemWindow UIAmendRiskWindow
        {
            get
            {
                if ((mUIAmendRiskWindow == null))
                {
                    mUIAmendRiskWindow = new UIItemWindow(this, "29");
                }
                return mUIAmendRiskWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIAmendRiskWindow;

        #endregion
    }
}