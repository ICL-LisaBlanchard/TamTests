namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UICurrentOrFutureWindow : WinWindow
    {
        public UICurrentOrFutureWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Current Or Future";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "TfCurrentOrFuture";
            WindowTitles.Add("Current Or Future");

            #endregion
        }

        #region Properties

        public UIClient UIClient
        {
            get
            {
                if ((mUICurrentOrFutureClient == null))
                {
                    mUICurrentOrFutureClient = new UIClient(this, "Current Or Future");
                }
                return mUICurrentOrFutureClient;
            }
        }

        #endregion

        #region Fields

        private UIClient mUICurrentOrFutureClient;

        #endregion
    }
}