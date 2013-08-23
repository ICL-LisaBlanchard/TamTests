namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIMTAsuccessfullyproceWindow : WinWindow
    {
        public UIMTAsuccessfullyproceWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "65535";
            this.WindowTitles.Add("MTA Successful");

            #endregion
        }

        #region Properties

        public WinText UIMTAsuccessfullyproceText
        {
            get
            {
                if ((this.mUIMTAsuccessfullyproceText == null))
                {
                    this.mUIMTAsuccessfullyproceText = new WinText(this);

                    #region Search Criteria

                    this.mUIMTAsuccessfullyproceText.SearchProperties[UITestControl.PropertyNames.Name] =
                        "MTA successfully processed on a previously renewed policy.WARNING! - RENEWAL EDI "
                        + "HAS BEEN CANCELLEDThe renewal status has been stepped back to Due. You will need" + " to process the renewal again via the Amend Risk option.";
                    this.mUIMTAsuccessfullyproceText.WindowTitles.Add("MTA Successful");

                    #endregion
                }
                return this.mUIMTAsuccessfullyproceText;
            }
        }

        #endregion

        #region Fields

        private WinText mUIMTAsuccessfullyproceText;

        #endregion
    }
}