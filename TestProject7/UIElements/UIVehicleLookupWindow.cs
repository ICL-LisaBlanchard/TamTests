namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVehicleLookupWindow : WinWindow
    {
        
        public UIVehicleLookupWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Vehicle Lookup";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Vehicle Lookup");
            #endregion
        }
        
        #region Properties
        public UIItemWindow10 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow10(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIFilterWindow UIFilterWindow
        {
            get
            {
                if ((this.mUIFilterWindow == null))
                {
                    this.mUIFilterWindow = new UIFilterWindow(this);
                }
                return this.mUIFilterWindow;
            }
        }
        
        public UIOKWindow11 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow11(this);
                }
                return this.mUIOKWindow;
            }
        }
        
        public UIItemWindow15 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow15(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UIItemWindow112 UIItemWindow11
        {
            get
            {
                if ((this.mUIItemWindow11 == null))
                {
                    this.mUIItemWindow11 = new UIItemWindow112(this);
                }
                return this.mUIItemWindow11;
            }
        }
        
        public UIFilterWindow1 UIFilterWindow1
        {
            get
            {
                if ((this.mUIFilterWindow1 == null))
                {
                    this.mUIFilterWindow1 = new UIFilterWindow1(this);
                }
                return this.mUIFilterWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow10 mUIItemWindow;
        
        private UIFilterWindow mUIFilterWindow;
        
        private UIOKWindow11 mUIOKWindow;
        
        private UIItemWindow15 mUIItemWindow1;
        
        private UIItemWindow112 mUIItemWindow11;
        
        private UIFilterWindow1 mUIFilterWindow1;
        #endregion
    }
}