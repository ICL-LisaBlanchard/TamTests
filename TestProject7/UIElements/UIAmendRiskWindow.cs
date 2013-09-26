namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIAmendRiskWindow : WinWindow
    {
        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "2", instance: "4");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIProposerDetailsWindow
        {
            get
            {
                if ((mUIProposerDetailsWindow == null))
                {
                    mUIProposerDetailsWindow = new UIItemWindow(this, controlId: "41");
                }
                return mUIProposerDetailsWindow;
            }
        }

        public UIItemWindow UICalculateQuoteWindow
        {
            get
            {
                if ((mUICalculateQuoteWindow == null))
                {
                    mUICalculateQuoteWindow = new UIItemWindow(this, controlId: "27");
                }
                return mUICalculateQuoteWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIProposerDetailsWindow;

        private UIItemWindow mUICalculateQuoteWindow;

        #endregion

        public UIAmendRiskWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Amend Risk";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("Amend Risk");

            #endregion
        }
    }
}