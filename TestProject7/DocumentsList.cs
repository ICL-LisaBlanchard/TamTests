namespace AppliedSystems.Tam.Ui.Tests
{
    using System.Collections.Generic;

    public class DocumentsList
    {
        public List<Document> DocumentsForHhNewBusinessQuote
        {
            get
            {
                return new List<Document>
                           {
                               new Document("HHQuotesList", 1),
                               new Document("HHQuote", 1),
                               new Document("Schedule", 1),
                               new Document("Proposal", 1),
                               new Document("FSA", 1)
                           };
            }
        }

        public List<Document> DocumentsForHhSaveQuoteWithoutPremium
        {
            get
            {
                return new List<Document>
                           {
                               new Document("HHQuotesList", 3),
                               new Document("HHQuote", 2),
                               new Document("Schedule", 1),
                               new Document("Proposal", 1),
                               new Document("FSA", 1)
                           };
            }
        }

        public List<Document> DocumentsForMotoNewBusinessQuote
        {
            get
            {
                return new List<Document>
                           {
                               new Document("QuotesList", 1),
                               new Document("Quote", 1),
                               new Document("Schedule", 1),
                               new Document("Proposal", 1),
                               new Document("Certificate", 1),
                               new Document("FSA", 1)
                           };
            }
        }

        public List<Document> DocumentsForMotoNewBusinessCancelAccept
        {
            get
            {
                return new List<Document>
                           {
                               new Document("QuotesList", 2),
                               new Document("Quote", 1),
                               new Document("Schedule", 2),
                               new Document("Proposal", 1),
                               new Document("Certificate", 1),
                               new Document("FSA", 1)
                           };
            }
        }
    }

    public class Document

    {
        public Document(string docName, int expectedCount)
        {
            this.DocName = docName;
            this.ExpectedCount = expectedCount;
            this.ActualCount = 0;
        }

        public string DocName { get; set; }

        public int ExpectedCount { get; set; }

        public int ActualCount { get; set; }
    }
}