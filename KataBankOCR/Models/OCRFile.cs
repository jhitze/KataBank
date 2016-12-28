using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace KataBankOCR.Models
{
    public class OCRFile
    {
        public OCRFile(Stream fileContents)
        {
            FileContents = fileContents;
        }

        public List<string> Parse()
        {
            List<string> accountNumbers = new List<string>();

            List<string> fileLines = new List<string>();
            // Read through stream
            StreamReader reader = new StreamReader(FileContents);
            while (!reader.EndOfStream)
            {
                // find line breaks
                fileLines.Add(reader.ReadLine());
            }

            // build groupings of account numbers
            // use OCRAccountNumberParser class to parse groupings
            // return List<string>AccountNumbers
            return accountNumbers;
        }

        private Stream FileContents
        {
            get;
            set;
        }
    }
}