using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KataBankOCR.Models
{
    public class OCRAccountNumberParser
    {
        public string ParseLines(List<string> accountNumberLines)
        {
            string accountNumber = string.Empty;
            // Split into sections of 3 chars
            for (int i = 0; i < 27; i = i + 3)
            {
                string[] numberToParse = new string[] { accountNumberLines[0].Substring(i,3),
                                                        accountNumberLines[1].Substring(i,3),
                                                        accountNumberLines[2].Substring(i,3),
                                                        accountNumberLines[3].Substring(i,3)
                                                      };
                // send to Number reader
                string parsedNumber = OCRNumberParser.parse(numberToParse);
                accountNumber += parsedNumber;
            }
            
            return accountNumber;
        }
    }
}