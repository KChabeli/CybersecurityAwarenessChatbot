using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class SentimentAnalyzer
    {
        public static string DetectSentiment(string input)
        {
            input = input.ToLower();
            if (input.Contains("worried") || input.Contains("scared")) return "worried";
            if (input.Contains("curious") || input.Contains("interested")) return "curious";
            if (input.Contains("frustrated") || input.Contains("angry")) return "frustrated";
            return "neutral";
        }
    }
}