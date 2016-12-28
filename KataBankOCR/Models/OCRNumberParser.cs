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


        public static string parse(string[] suspectedNumber)
        {
            // a1.OrderBy(a => a).SequenceEqual(a2.OrderBy(a => a));
            if (suspectedNumber.OrderBy(a =>a).SequenceEqual(zero.OrderBy(a => a)))
            {
                return "0";
            }
            else if (suspectedNumber.OrderBy(a => a).SequenceEqual(one.OrderBy(a => a)))
            {
                return "1";
            }
            else if (suspectedNumber.OrderBy(a => a).SequenceEqual(two.OrderBy(a => a)))
            {
                return "2";
            }
            else if (suspectedNumber.OrderBy(a => a).SequenceEqual(three.OrderBy(a => a)))
            {
                return "3";
            }
            else if (suspectedNumber.OrderBy(a => a).SequenceEqual(four.OrderBy(a => a)))
            {
                return "4";
            }
            else if (suspectedNumber.OrderBy(a => a).SequenceEqual(five.OrderBy(a => a)))
            {
                return "5";
            }
            else if (suspectedNumber.OrderBy(a => a).SequenceEqual(six.OrderBy(a => a)))
            {
                return "6";
            }
            else if (suspectedNumber.OrderBy(a => a).SequenceEqual(seven.OrderBy(a => a)))
            {
                return "7";
            }
            else if (suspectedNumber.OrderBy(a => a).SequenceEqual(eight.OrderBy(a => a)))
            {
                return "8";
            }
            else if (suspectedNumber.OrderBy(a => a).SequenceEqual(nine.OrderBy(a => a)))
            {
                return "9";
            }
            return "";
        }
    }
}