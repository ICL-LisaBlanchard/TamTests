namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAmendRiskWindow1 : WinWindow
    {
        public UIAmendRiskWindow1()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Amend Risk";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Amend Risk");

            #endregion
        }

        #region Properties

        public UIItemWindow68 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow68(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIProposerDetailsWindow1 UIProposerDetailsWindow
        {
            get
            {
                if ((this.mUIProposerDetailsWindow == null))
                {
                    this.mUIProposerDetailsWindow = new UIProposerDetailsWindow1(this);
                }
                return this.mUIProposerDetailsWindow;
            }
        }

        public UICalculateQuoteWindow1 UICalculateQuoteWindow
        {
            get
            {
                if ((this.mUICalculateQuoteWindow == null))
                {
                    this.mUICalculateQuoteWindow = new UICalculateQuoteWindow1(this);
                }
                return this.mUICalculateQuoteWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow68 mUIItemWindow;

        private UIProposerDetailsWindow1 mUIProposerDetailsWindow;

        private UICalculateQuoteWindow1 mUICalculateQuoteWindow;

        #endregion
    }
}