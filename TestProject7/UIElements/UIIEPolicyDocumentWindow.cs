namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System;

    using Microsoft.VisualStudio.TestTools.UITesting;

    public class UIIEPolicyDocumentWindow : BrowserWindow
    {
        public UIIEPolicyDocumentWindow()
        {
            #region Search Criteria

            this.SearchProperties.Add(new PropertyExpression(PropertyNames.Name, "Quote", PropertyExpressionOperator.Contains));

            this.SearchProperties[PropertyNames.ClassName] = "IEFrame";
            //this.WindowTitles.Add("\\HHQuote.htm");

            #endregion
        }

        public void LaunchUrl(Uri url)
        {
            this.CopyFrom(Launch(url));
        }

        #region Properties

        public UIFileCUsersLisaBlanchDocument UIFileCUsersLisaBlanchDocument
        {
            get
            {
                if ((this.mUIFileCUsersLisaBlanchDocument == null))
                {
                    this.mUIFileCUsersLisaBlanchDocument = new UIFileCUsersLisaBlanchDocument(this);
                }
                return this.mUIFileCUsersLisaBlanchDocument;
            }
        }

        #endregion

        #region Fields

        private UIFileCUsersLisaBlanchDocument mUIFileCUsersLisaBlanchDocument;

        #endregion
    }
}