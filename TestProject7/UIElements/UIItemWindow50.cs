namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow50 : WinWindow
    {
        public UIItemWindow50(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TPanel";
            this.WindowTitles.Add("Which policy would you like to take the risk details from?");

            #endregion
        }

        #region Properties

        public UIWhichpolicywouldyoulClient UIWhichpolicywouldyoulClient
        {
            get
            {
                if ((this.mUIWhichpolicywouldyoulClient == null))
                {
                    this.mUIWhichpolicywouldyoulClient = new UIWhichpolicywouldyoulClient(this);
                }
                return this.mUIWhichpolicywouldyoulClient;
            }
        }

        #endregion

        #region Fields

        private UIWhichpolicywouldyoulClient mUIWhichpolicywouldyoulClient;

        #endregion
    }
}