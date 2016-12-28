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
    public class OCRNumberParserTests
    {
        [TestMethod()]
        public void parseTest_Zero()
        {
            string[] test = new string[] { " _ ", "| |", "|_|", "   " };

            string result = OCRNumberParser.parse(test);

            Assert.AreEqual("0", result);
        }

        [TestMethod()]
        public void parseTest_One()
        {
            string[] test = new string[] { "   ", "  |", "  |", "   " };

            string result = OCRNumberParser.parse(test);

            Assert.AreEqual("1", result);
        }

        [TestMethod()]
        public void parseTest_Two()
        {
            string[] test = new string[] { " _ ", " _|", "|_ ", "   " };

            string result = OCRNumberParser.parse(test);

            Assert.AreEqual("2", result);
        }

        [TestMethod()]
        public void parseTest_Three()
        {
            string[] test = new string[] { " _ ", " _|", " _|", "   " };

            string result = OCRNumberParser.parse(test);

            Assert.AreEqual("3", result);
        }

        [TestMethod()]
        public void parseTest_Four()
        {
            string[] test = new string[] { "   ", "|_|", "  |", "   " };

            string result = OCRNumberParser.parse(test);

            Assert.AreEqual("4", result);
        }

        [TestMethod()]
        public void parseTest_Five()
        {
            string[] test = new string[] { " _ ",
                                           "|_ ",
                                           " _|",
                                           "   " };

            string result = OCRNumberParser.parse(test);

            Assert.AreEqual("5", result);
        }

        [TestMethod()]
        public void parseTest_Six()
        {
            string[] test = new string[] { " _ ", "|_ ", "|_|", "   " };

            string result = OCRNumberParser.parse(test);

            Assert.AreEqual("6", result);
        }

        [TestMethod()]
        public void parseTest_Seven()
        {
            string[] test = new string[] { " _ ", "  |", "  |", "   " };

            string result = OCRNumberParser.parse(test);

            Assert.AreEqual("7", result);
        }

        [TestMethod()]
        public void parseTest_Eight()
        {
            string[] test = new string[] { " _ ", "|_|", "|_|", "   " };

            string result = OCRNumberParser.parse(test);

            Assert.AreEqual("8", result);
        }

        [TestMethod()]
        public void parseTest_Nine()
        {
            string[] test = new string[] { " _ ", "|_|", " _|", "   " };

            string result = OCRNumberParser.parse(test);

            Assert.AreEqual("9", result);
        }


    }
}