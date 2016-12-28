using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataBankOCR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KataBankOCR.Models.Tests
{
    [TestClass()]
    public class OCRFileTests
    {
        [TestMethod()]
        public void ParseFileTest()
        {
            OCRFile ocrTest;
            using (StreamReader reader = new StreamReader(@"Models\BasicGoodAccountNumbers.txt"))
            {
                ocrTest = new OCRFile(reader.BaseStream);
                var expected = ocrTest.Parse();
                Assert.AreEqual(expected[0], "000000000");
                Assert.AreEqual(expected[1], "111111111");
                Assert.AreEqual(expected[2], "222222222");
                Assert.AreEqual(expected[3], "333333333");
                Assert.AreEqual(expected[4], "444444444");
                Assert.AreEqual(expected[5], "555555555");
                Assert.AreEqual(expected[6], "666666666");
                Assert.AreEqual(expected[7], "777777777");
                Assert.AreEqual(expected[8], "888888888");
                Assert.AreEqual(expected[9], "999999999");
                Assert.AreEqual(expected[10], "123456789");
            }
        }
    }
}