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
    }
}