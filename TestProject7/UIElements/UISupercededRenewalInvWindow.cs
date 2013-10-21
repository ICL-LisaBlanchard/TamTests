namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UISupercededRenewalInvWindow : WinWindow
    {

        public UISupercededRenewalInvWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Superceded Renewal Invitations";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Superceded Renewal Invitations");
            #endregion
        }

        #region Properties
        public UIItemWindow UISaveWindow
        {
            get
            {
                if ((this.mUISaveWindow == null))
                {
                    this.mUISaveWindow = new UIItemWindow(this, controlId: "3");
                }
                return this.mUISaveWindow;
            }
        }
        #endregion

        #region Fields
        private UIItemWindow mUISaveWindow;
        #endregion
    }
}
