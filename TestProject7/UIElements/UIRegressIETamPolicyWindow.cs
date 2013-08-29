namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRegressIETamPolicyWindow : WinWindow
    {
        public UIRegressIETamPolicyWindow()
        {
            #region Search Criteria

            this.windowName = "Regress IETam Policy";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowName;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "8");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow(this, controlId: "11");
                }
                return this.mUIItemWindow2;
            }
        }

        public UIItemWindow UIRegressWindow
        {
            get
            {
                if ((this.mUIRegressWindow == null))
                {
                    this.mUIRegressWindow = new UIItemWindow(this, controlId: "10");
                }
                return this.mUIRegressWindow;
            }
        }

        public UIItemWindow UIExitWindow
        {
            get
            {
                if ((this.mUIExitWindow == null))
                {
                    this.mUIExitWindow = new UIItemWindow(this, controlId: "12");
                }
                return this.mUIExitWindow;
            }
        }

        public UIItemWindow UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow(this, controlId: "10");
                }
                return this.mUIItemWindow3;
            }
        }

        public UIItemWindow UIItemWindow4
        {
            get
            {
                if ((this.mUIItemWindow4 == null))
                {
                    this.mUIItemWindow4 = new UIItemWindow(this, controlId: "3");
                }
                return this.mUIItemWindow4;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIItemWindow2;

        private UIItemWindow mUIRegressWindow;

        private UIItemWindow mUIExitWindow;

        private UIItemWindow mUIItemWindow3;

        private UIItemWindow mUIItemWindow4;

        #endregion
    }
}