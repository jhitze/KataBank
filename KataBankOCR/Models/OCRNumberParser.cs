using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KataBankOCR.Models
{
    public static class OCRNumberParser
    {
        private static string[] zero = new string[] { " _ ", "| |", "|_|", "   " };


        public static string parse(string[] suspectedNumber)
        {
            // a1.OrderBy(a => a).SequenceEqual(a2.OrderBy(a => a));
            if (suspectedNumber.OrderBy(a =>a).SequenceEqual(zero.OrderBy(a => a)))
            {
                return "0";
            }
            return "";
        }
    }
}