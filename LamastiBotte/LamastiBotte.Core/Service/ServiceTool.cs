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
            string pattern = "[A-Za-z ]*";
            string outputMessage = Regex.Match(inputMessage, pattern).Value;

            return outputMessage;
        }
    }
}
