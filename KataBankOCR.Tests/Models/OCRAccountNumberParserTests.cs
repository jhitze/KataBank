using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataBankOCR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataBankOCR.Models.Tests
{
    [TestClass()]
    public class OCRAccountNumberParserTests
    {
        [TestMethod()]
        public void ParseLinesTest_User1_AllZeros()
        {
            List<string> useCase1 = new List<string>();
            useCase1.Add(" _  _  _  _  _  _  _  _  _ ");
            useCase1.Add("| || || || || || || || || |");
            useCase1.Add("|_||_||_||_||_||_||_||_||_|");
            useCase1.Add("                           ");

            OCRAccountNumberParser parser = new OCRAccountNumberParser();
            string result = parser.ParseLines(useCase1);

            Assert.AreEqual("000000000", result);
        }

        [TestMethod()]
        public void ParseLinesTest_User1_AllOnes()
        {
            List<string> useCase1 = new List<string>();
            useCase1.Add("                           ");
            useCase1.Add("  |  |  |  |  |  |  |  |  |");
            useCase1.Add("  |  |  |  |  |  |  |  |  |");
            useCase1.Add("                           ");

            OCRAccountNumberParser parser = new OCRAccountNumberParser();
            string result = parser.ParseLines(useCase1);

            Assert.AreEqual("111111111", result);
        }
    }
}