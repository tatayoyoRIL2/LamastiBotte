using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LamastiBotte.Core.Service
{
    public static class ServiceTool
    {
        public static string FormatMessage(string inputMessage)
        {
            string pattern = "";
            string outputMessage = Regex.Replace(inputMessage, @"[^0-9a-zA-Z ]+", "");

            outputMessage = outputMessage.ToLower();

            char[] trimChars = { ' ' };
            outputMessage = outputMessage.TrimEnd(trimChars);
            outputMessage = outputMessage.TrimStart(trimChars);

            return outputMessage;
        }
    }
}
