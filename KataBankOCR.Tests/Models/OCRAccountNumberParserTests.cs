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

        [TestMethod()]
        public void ParseLinesTest_User1_AllTwos()
        {
            List<string> useCase1 = new List<string>();
            useCase1.Add(" _  _  _  _  _  _  _  _  _ ");
            useCase1.Add(" _| _| _| _| _| _| _| _| _|");
            useCase1.Add("|_ |_ |_ |_ |_ |_ |_ |_ |_ ");
            useCase1.Add("                           ");

            OCRAccountNumberParser parser = new OCRAccountNumberParser();
            string result = parser.ParseLines(useCase1);

            Assert.AreEqual("222222222", result);
        }

        [TestMethod()]
        public void ParseLinesTest_User1_AllThrees()
        {
            List<string> useCase1 = new List<string>();
            useCase1.Add(" _  _  _  _  _  _  _  _  _ ");
            useCase1.Add(" _| _| _| _| _| _| _| _| _|");
            useCase1.Add(" _| _| _| _| _| _| _| _| _|");
            useCase1.Add("                           ");

            OCRAccountNumberParser parser = new OCRAccountNumberParser();
            string result = parser.ParseLines(useCase1);

            Assert.AreEqual("333333333", result);
        }

        [TestMethod()]
        public void ParseLinesTest_User1_AllFours()
        {
            List<string> useCase1 = new List<string>();
            useCase1.Add("                           ");
            useCase1.Add("|_||_||_||_||_||_||_||_||_|");
            useCase1.Add("  |  |  |  |  |  |  |  |  |");
            useCase1.Add("                           ");

            OCRAccountNumberParser parser = new OCRAccountNumberParser();
            string result = parser.ParseLines(useCase1);

            Assert.AreEqual("444444444", result);
        }

        [TestMethod()]
        public void ParseLinesTest_User1_AllFives()
        {
            List<string> useCase1 = new List<string>();
            useCase1.Add(" _  _  _  _  _  _  _  _  _ ");
            useCase1.Add("|_ |_ |_ |_ |_ |_ |_ |_ |_ ");
            useCase1.Add(" _| _| _| _| _| _| _| _| _|");
            useCase1.Add("                           ");

            OCRAccountNumberParser parser = new OCRAccountNumberParser();
            string result = parser.ParseLines(useCase1);

            Assert.AreEqual("555555555", result);
        }

        [TestMethod()]
        public void ParseLinesTest_User1_AllSixes()
        {
            List<string> useCase1 = new List<string>();
            useCase1.Add(" _  _  _  _  _  _  _  _  _ ");
            useCase1.Add("|_ |_ |_ |_ |_ |_ |_ |_ |_ ");
            useCase1.Add("|_||_||_||_||_||_||_||_||_|");
            useCase1.Add("                           ");

            OCRAccountNumberParser parser = new OCRAccountNumberParser();
            string result = parser.ParseLines(useCase1);

            Assert.AreEqual("666666666", result);
        }

        [TestMethod()]
        public void ParseLinesTest_User1_AllSevens()
        {
            List<string> useCase1 = new List<string>();
            useCase1.Add(" _  _  _  _  _  _  _  _  _ ");
            useCase1.Add("  |  |  |  |  |  |  |  |  |");
            useCase1.Add("  |  |  |  |  |  |  |  |  |");
            useCase1.Add("                           ");

            OCRAccountNumberParser parser = new OCRAccountNumberParser();
            string result = parser.ParseLines(useCase1);

            Assert.AreEqual("777777777", result);
        }

        [TestMethod()]
        public void ParseLinesTest_User1_AllEights()
        {
            List<string> useCase1 = new List<string>();
            useCase1.Add(" _  _  _  _  _  _  _  _  _ ");
            useCase1.Add("|_||_||_||_||_||_||_||_||_|");
            useCase1.Add("|_||_||_||_||_||_||_||_||_|");
            useCase1.Add("                           ");

            OCRAccountNumberParser parser = new OCRAccountNumberParser();
            string result = parser.ParseLines(useCase1);

            Assert.AreEqual("888888888", result);
        }

        [TestMethod()]
        public void ParseLinesTest_User1_AllNines()
        {
            List<string> useCase1 = new List<string>();
            useCase1.Add(" _  _  _  _  _  _  _  _  _ ");
            useCase1.Add("|_||_||_||_||_||_||_||_||_|");
            useCase1.Add(" _| _| _| _| _| _| _| _| _|");
            useCase1.Add("                           ");

            OCRAccountNumberParser parser = new OCRAccountNumberParser();
            string result = parser.ParseLines(useCase1);

            Assert.AreEqual("999999999", result);
        }
    }
}