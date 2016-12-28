using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KataBankOCR.Models
{
    public static class OCRNumberParser
    {
        private static string[] zero = new string[] { " _ ",
                                                      "| |",
                                                      "|_|",
                                                      "   " };
        private static string[] one = new string[] { "   ",
                                                     "  |",
                                                     "  |",
                                                     "   " };

        private static string[] two = new string[] { " _ ",
                                                     " _|",
                                                     "|_ ",
                                                     "   " };

        private static string[] three = new string[] { " _ ",
                                                       " _|",
                                                       " _|",
                                                       "   " };

        private static string[] four = new string[] { "   ",
                                                      "|_|",
                                                      "  |",
                                                      "   " };

        private static string[] five = new string[] { " _ ",
                                                      "|_ ",
                                                      " _|",
                                                      "   " };

        private static string[] six = new string[] { " _ ",
                                                     "|_ ",
                                                     "|_|",
                                                     "   " };

        private static string[] seven = new string[] { " _ ",
                                                       "  |",
                                                       "  |",
                                                       "   " };

        private static string[] eight = new string[] { " _ ",
                                                       "|_|",
                                                       "|_|",
                                                       "   " };

        private static string[] nine = new string[] { " _ ",
                                                      "|_|",
                                                      " _|",
                                                      "   " };


        /// <summary>
        /// Simplify array of strings to a single string. 
        /// </summary>
        /// <param name="suspectedNumber"></param>
        /// <returns></returns>
        /// http://stackoverflow.com/a/3232758
        public static string parse(string[] suspectedNumber)
        {
            if (suspectedNumber.SequenceEqual(zero))
            {
                return "0";
            }
            else if (suspectedNumber.SequenceEqual(one))
            {
                return "1";
            }
            else if (suspectedNumber.SequenceEqual(two))
            {
                return "2";
            }
            else if (suspectedNumber.SequenceEqual(three))
            {
                return "3";
            }
            else if (suspectedNumber.SequenceEqual(four))
            {
                return "4";
            }
            else if (suspectedNumber.SequenceEqual(five))
            {
                return "5";
            }
            else if (suspectedNumber.SequenceEqual(six))
            {
                return "6";
            }
            else if (suspectedNumber.SequenceEqual(seven))
            {
                return "7";
            }
            else if (suspectedNumber.SequenceEqual(eight))
            {
                return "8";
            }
            else if (suspectedNumber.SequenceEqual(nine))
            {
                return "9";
            }
            return "";
        }
    }
}