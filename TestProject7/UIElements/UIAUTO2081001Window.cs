namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAUTO2081001Window : WinWindow
    {
        public UIAUTO2081001Window()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "AUTO208-1001";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("AUTO208-1001");

            #endregion
        }

        #region Properties

        public UIRebrokeWindow UIRebrokeWindow
        {
            get
            {
                if ((this.mUIRebrokeWindow == null))
                {
                    this.mUIRebrokeWindow = new UIRebrokeWindow(this);
                }
                return this.mUIRebrokeWindow;
            }
        }

        public UIAmendRiskWindow UIAmendRiskWindow
        {
            get
            {
                if ((this.mUIAmendRiskWindow == null))
                {
                    this.mUIAmendRiskWindow = new UIAmendRiskWindow(this);
                }
                return this.mUIAmendRiskWindow;
            }
        }

        #endregion

        #region Fields

        private UIRebrokeWindow mUIRebrokeWindow;

        private UIAmendRiskWindow mUIAmendRiskWindow;

        #endregion
    }
}