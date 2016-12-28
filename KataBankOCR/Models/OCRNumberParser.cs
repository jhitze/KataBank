using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KataBankOCR.Models
{
    public static class OCRNumberParser
    {
        private static string[] zero = new string[] { " _ ", "| |", "|_|", "   " };
        private static string[] one = new string[] { "   ", "  |", "  |", "   " };


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
            return "";
        }
    }
}