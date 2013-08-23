namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITheAgencyManagerSignWindow : WinWindow
    {
        
        public UITheAgencyManagerSignWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("The Agency Manager Signon");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIOKWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow(this);
                }
                return this.mUIOKWindow;
            }
        }
        
        public UIOKWindow1 UIOKWindow1
        {
            get
            {
                if ((this.mUIOKWindow1 == null))
                {
                    this.mUIOKWindow1 = new UIOKWindow1(this);
                }
                return this.mUIOKWindow1;
            }
        }
        
        public UIOKWindow2 UIOKWindow2
        {
            get
            {
                if ((this.mUIOKWindow2 == null))
                {
                    this.mUIOKWindow2 = new UIOKWindow2(this);
                }
                return this.mUIOKWindow2;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UIItemWindow2 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow2(this);
                }
                return this.mUIItemWindow2;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIOKWindow mUIOKWindow;
        
        private UIOKWindow1 mUIOKWindow1;
        
        private UIOKWindow2 mUIOKWindow2;
        
        private UIItemWindow1 mUIItemWindow1;
        
        private UIItemWindow2 mUIItemWindow2;
        #endregion
    }
}