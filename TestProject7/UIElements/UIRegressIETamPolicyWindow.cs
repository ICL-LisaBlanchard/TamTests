namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRegressIETamPolicyWindow : WinWindow
    {
        public UIRegressIETamPolicyWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Regress IETam Policy";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Regress IETam Policy");

            #endregion
        }

        #region Properties

        public UIItemWindow62 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow62(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow214 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow214(this);
                }
                return this.mUIItemWindow2;
            }
        }

        public UIRegressWindow UIRegressWindow
        {
            get
            {
                if ((this.mUIRegressWindow == null))
                {
                    this.mUIRegressWindow = new UIRegressWindow(this);
                }
                return this.mUIRegressWindow;
            }
        }

        public UIItemWindow126 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow126(this);
                }
                return this.mUIItemWindow1;
            }
        }

        public UIExitWindow4 UIExitWindow
        {
            get
            {
                if ((this.mUIExitWindow == null))
                {
                    this.mUIExitWindow = new UIExitWindow4(this);
                }
                return this.mUIExitWindow;
            }
        }

        public UIItemWindow312 UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow312(this);
                }
                return this.mUIItemWindow3;
            }
        }

        public UIItemWindow410 UIItemWindow4
        {
            get
            {
                if ((this.mUIItemWindow4 == null))
                {
                    this.mUIItemWindow4 = new UIItemWindow410(this);
                }
                return this.mUIItemWindow4;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow62 mUIItemWindow;

        private UIItemWindow214 mUIItemWindow2;

        private UIRegressWindow mUIRegressWindow;

        private UIItemWindow126 mUIItemWindow1;

        private UIExitWindow4 mUIExitWindow;

        private UIItemWindow312 mUIItemWindow3;

        private UIItemWindow410 mUIItemWindow4;

        #endregion
    }
}