using Microsoft.Office.Interop.Word;

namespace AppliedSystems.Tam.Ui.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class Documents
    {
        public void CheckWordDoc(string fileName, string premium)
        {
            var application = new Application();
            var document = application.Documents.Open(fileName);

            var body = document.Content.Text;

            Assert.IsTrue(body.Contains(premium), "Body does not contain premium");

            application.Quit();
        }
    }
}
