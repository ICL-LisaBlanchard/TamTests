namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;

    using iTextSharp.text.pdf;

    public class PDFParser
    {

        private const int NumberOfCharsToKeep = 15;

        public bool ExtractText(string inFileName, string outFileName)
        {
            StreamWriter outFile = null;
            try
            {
                // Create a reader for the given PDF file
                var reader = new PdfReader(inFileName);
                //outFile = File.CreateText(outFileName);
                outFile = new StreamWriter(outFileName, false, Encoding.UTF8);

                Console.Write("Processing: ");

                const int TotalLen = 68;
                float charUnit = (TotalLen) / (float)reader.NumberOfPages;
                int totalWritten = 0;
                float curUnit = 0;

                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    outFile.Write(ExtractTextFromPDFBytes(reader.GetPageContent(page)) + " ");

                    // Write the progress.
                    if (charUnit >= 1.0f)
                    {
                        for (int i = 0; i < (int)charUnit; i++)
                        {
                            Console.Write("#");
                            totalWritten++;
                        }
                    }
                    else
                    {
                        curUnit += charUnit;
                        if (curUnit >= 1.0f)
                        {
                            for (int i = 0; i < (int)curUnit; i++)
                            {
                                Console.Write("#");
                                totalWritten++;
                            }
                            curUnit = 0;
                        }
                    }
                }

                if (totalWritten < TotalLen)
                {
                    for (int i = 0; i < (TotalLen - totalWritten); i++)
                    {
                        Console.Write("#");
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (outFile != null)
                {
                    outFile.Close();
                }
            }
        }

        public string ExtractText(string inFileName)
        {
            string outputText = string.Empty;
            try
            {
                var reader = new PdfReader(inFileName);

                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    outputText += (ExtractTextFromPDFBytes(reader.GetPageContent(page)) + " ");
                }

                reader.Close();

                return outputText;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ExtractTextFromPDFBytes(byte[] input)
        {
            if (input == null || input.Length == 0)
            {
                return "";
            }

            try
            {
                string resultString = "";

                // Flag showing if we are we currently inside a text object
                bool inTextObject = false;

                // Flag showing if the next character is literal 
                // e.g. '\\' to get a '\' character or '\(' to get '('
                bool nextLiteral = false;

                // () Bracket nesting level. Text appears inside ()
                int bracketDepth = 0;

                // Keep previous chars to get extract numbers etc.:
                var previousCharacters = new char[NumberOfCharsToKeep];
                for (int j = 0; j < NumberOfCharsToKeep; j++)
                {
                    previousCharacters[j] = ' ';
                }

                foreach (byte t in input)
                {
                    var c = (char)t;

                    if (inTextObject)
                    {
                        // Position the text
                        if (bracketDepth == 0)
                        {
                            if (CheckToken(new[] { "TD", "Td" }, previousCharacters))
                            {
                                resultString += "\n\r";
                            }
                            else
                            {
                                if (CheckToken(new[] { "'", "T*", "\"" }, previousCharacters))
                                {
                                    resultString += "\n";
                                }
                                else
                                {
                                    if (CheckToken(new[] { "Tj" }, previousCharacters))
                                    {
                                        resultString += " ";
                                    }
                                }
                            }
                        }

                        // End of a text object, also go to a new line.
                        if (bracketDepth == 0 && CheckToken(new[] { "ET" }, previousCharacters))
                        {
                            inTextObject = false;
                            resultString += " ";
                        }
                        else
                        {
                            // Start outputting text
                            if ((c == '(') && (bracketDepth == 0) && (!nextLiteral))
                            {
                                bracketDepth = 1;
                            }
                            else
                            {
                                // Stop outputting text
                                if ((c == ')') && (bracketDepth == 1) && (!nextLiteral))
                                {
                                    bracketDepth = 0;
                                }
                                else
                                {
                                    // Just a normal text character:
                                    if (bracketDepth == 1)
                                    {
                                        // Only print out next character no matter what. 
                                        // Do not interpret.
                                        if (c == '\\' && !nextLiteral)
                                        {
                                            nextLiteral = true;
                                        }
                                        else
                                        {
                                            if (((c >= ' ') && (c <= '~')) || ((c >= 128) && (c < 255)))
                                            {
                                                resultString += c.ToString(CultureInfo.InvariantCulture);
                                            }

                                            nextLiteral = false;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    // Store the recent characters for 
                    // when we have to go back for a checking
                    for (int j = 0; j < NumberOfCharsToKeep - 1; j++)
                    {
                        previousCharacters[j] = previousCharacters[j + 1];
                    }
                    previousCharacters[NumberOfCharsToKeep - 1] = c;

                    // Start of a text object
                    if (!inTextObject && CheckToken(new[] { "BT" }, previousCharacters))
                    {
                        inTextObject = true;
                    }
                }
                return resultString;
            }
            catch
            {
                return "";
            }
        }



        #region CheckToken

        /// <summary>
        /// Check if a certain 2 character token just came along (e.g. BT)
        /// </summary>
        private static bool CheckToken(IEnumerable<string> tokens, IList<char> recent)
        {
            if (tokens == null)
            {
                throw new ArgumentNullException("tokens");
            }
            return
                tokens.Any(
                    token =>
                    (recent[NumberOfCharsToKeep - 3] == token[0]) && (recent[NumberOfCharsToKeep - 2] == token[1])
                    && ((recent[NumberOfCharsToKeep - 1] == ' ') || (recent[NumberOfCharsToKeep - 1] == 0x0d) || (recent[NumberOfCharsToKeep - 1] == 0x0a))
                    && ((recent[NumberOfCharsToKeep - 4] == ' ') || (recent[NumberOfCharsToKeep - 4] == 0x0d) || (recent[NumberOfCharsToKeep - 4] == 0x0a)));
        }

        #endregion


    }
}